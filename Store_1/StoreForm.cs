using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Configuration;
using System.Collections.Generic;

namespace Store_1
{
    public partial class StoreForm : Form
    {
        string Connection = ConfigurationManager.AppSettings.Get("ConString");
        //Строка подключения к файлу Backup
        string BackupFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments) + "\\StoreInfo";

        enum OperationType { Add = 1, Change = 2, Delete = 3 }

        Dictionary<int, string> OpTypeDictionary = new Dictionary<int, string>(5);
        enum StoreOperationType { Sale = 1, Return = 2, Add = 3, WriteOff = 4}

        bool isAdmin = false;

        public StoreForm()
        {
            InitializeComponent();
            Logger.LogFileCreate();
        }

        private DataTable LoadData()
        {
            DataTable DataTbl = new DataTable();
            using (SqlConnection StoreConnection = new SqlConnection(Connection))
            {
                string getData = @"Select [position],[price], [quantity],[first_price],[id] FROM [db_Shop].[dbo].[remain]";
                SqlCommand ComSql = new SqlCommand(getData, StoreConnection);
                SqlDataAdapter adapter = new SqlDataAdapter(ComSql);
                adapter.Fill(DataTbl);
            }
            return DataTbl;
        }

        private DataTable LoadData_Operations()
        {
            DataTable DataTbl = new DataTable();
            using (SqlConnection StoreConnection = new SqlConnection(Connection))
            {
                string getData = @"Select [id],[position_id], [oper_date], [operation_type], [position],[quantity],[price],[summ_price],[first_price] FROM [db_Shop].[dbo].[operations]";
                SqlCommand ComSql = new SqlCommand(getData, StoreConnection);
                SqlDataAdapter adapter = new SqlDataAdapter(ComSql);
                adapter.Fill(DataTbl);
            }
            return DataTbl;
        }

        //Установка значений компонентов формы по умолчанию
        private void SetDefault()
        {
            CurrentPositionTextBox.Text = "";
            CurrentQuantityTextBox.Text = "";
            StoreGrid.DataSource = LoadData();
            OperationsGrid.DataSource = LoadData_Operations();
            CurrentQuantityTextBox.ReadOnly = true;
        }

        private void StoreForm_Load(object sender, EventArgs e)
        {
            MakeBackup();
            Logger.LogText = "";
            SetUser(false, "kassir"); //Задается пользователь по умолчанию - кассир
            StoreGrid.DataSource = LoadData();
            OperationsGrid.DataSource = LoadData_Operations();

            OpTypeDictionary.Add((int)StoreOperationType.Sale, "Продажа");
            OpTypeDictionary.Add((int)StoreOperationType.Return, "Возврат");
            OpTypeDictionary.Add((int)StoreOperationType.Add, "Добавление");
            OpTypeDictionary.Add((int)StoreOperationType.WriteOff, "Списание");
        }

        private void ShowStartPriceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ShowStartPriceToolStripMenuItem.Text == "Показать закупочную цену")
            {
                gridColumn4.Visible = true;
                ShowStartPriceToolStripMenuItem.Text = "Скрыть закупочную цену";
            }
            else
            {
                gridColumn4.Visible = false;
                ShowStartPriceToolStripMenuItem.Text = "Показать закупочную цену";
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Ограничение вводимых символов
        private void CurrentQuantityTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void SaleButton_Click(object sender, EventArgs e)
        {
            if (CurrentPositionTextBox.Text.ToString() == "" || CurrentQuantityTextBox.Text.ToString() == "" )
            {
                MessageBox.Show("Не выбрано наименование или количество");
            }
            else
            {                
                ExecuteOperation((int)StoreOperationType.Sale, OpTypeDictionary[(int)StoreOperationType.Sale]);
                SetDefault();
            }
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            DataRowView CurrentRow = StoreGridView1.GetFocusedRow() as DataRowView;
            CurrentPositionTextBox.Text = CurrentRow["position"].ToString();

            CurrentQuantityTextBox.ReadOnly = false;
            
            ChangePositionButton.Enabled = isAdmin;
            DeletePositionButton.Enabled = isAdmin;
            
            CurrentQuantityTextBox.Text = "";
        }

        private void ExecuteOperation(int OpType, string OperationTypeName)
        {
            DataRowView CurrentRow = StoreGridView1.GetFocusedRow() as DataRowView;
            int op_id = Int32.Parse(CurrentRow["id"].ToString());
            int op_quantity = Int32.Parse(CurrentQuantityTextBox.Text);
            int op_price = Int32.Parse(CurrentRow["price"].ToString());
            int op_first_price = Int32.Parse(CurrentRow["first_price"].ToString());
            string op_position = CurrentRow["position"].ToString();




            using (SqlConnection StoreCon = new SqlConnection(Connection))
            {
                string StoreProc = @"sale";
                string StoreProc_2 = @"InsertTableOperations";

                StoreCon.Open();
                SqlTransaction sqlTran = StoreCon.BeginTransaction(); /*Начало транзакции*/
                SqlCommand ComSql = new SqlCommand(StoreProc, StoreCon);
                ComSql.Transaction = sqlTran; /*добавляем операцию в транзакцию*/
                SqlCommand ComSql_2 = new SqlCommand(StoreProc_2, StoreCon);
                ComSql_2.Transaction = sqlTran; /*добавляем операцию в транзакцию*/

                try
                {
                    ComSql.CommandType = CommandType.StoredProcedure;
                    ComSql.Parameters.AddWithValue("@op_type", OpType);
                    ComSql.Parameters.AddWithValue("@op_id", op_id);
                    ComSql.Parameters.AddWithValue("@op_quantity", op_quantity);
                    ComSql.Parameters.AddWithValue("@op_price", op_price);
                    ComSql.ExecuteNonQuery();



                    ComSql_2.CommandType = CommandType.StoredProcedure;
                    ComSql_2.Parameters.AddWithValue("@position_id", op_id);
                    ComSql_2.Parameters.AddWithValue("@operation_type", OperationTypeName);
                    ComSql_2.Parameters.AddWithValue("@position", op_position);
                    ComSql_2.Parameters.AddWithValue("@quantity", op_quantity);
                    ComSql_2.Parameters.AddWithValue("@price", op_price);
                    ComSql_2.Parameters.AddWithValue("@first_price", op_first_price);
                    ComSql_2.ExecuteNonQuery();
                                     
                    sqlTran.Commit();

                    Logger.LogText += OperationTypeName + "\r\n ID " + op_id + "\r\n Товар " + op_position +
                        "\r\n Количество " + op_quantity + "\r\n Цена " + op_price
                        + "\r\n Сумма " + op_price * op_quantity + "\r\n закупочная цена "
                        + op_first_price + "\r\n Пользователь " + UserLabel.Text + "\r\n";
                }
                catch (Exception e)
                {
                    sqlTran.Rollback();
                    MessageBox.Show(e.Message);
                    Logger.LogText += OperationTypeName + " Ошибка " + e.Message + "\r\n ID " + op_id + "\r\n Товар " + op_position +
                        "\r\n Количество " + op_quantity + "\r\n Цена " + op_price
                        + "\r\n Сумма " + op_price * op_quantity + "\r\n закупочная цена "
                        + op_first_price;
                }
                finally
                {
                    Logger.LogWrite(Logger.LogText);
                }


            }


        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            if (CurrentPositionTextBox.Text.ToString() == "" || CurrentQuantityTextBox.Text.ToString() == "")
            {
                MessageBox.Show("Не выбрано наименование или количество");
            }
            else
            {
                ExecuteOperation((int)StoreOperationType.Return, OpTypeDictionary[(int)StoreOperationType.Return]);
                SetDefault();
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (CurrentPositionTextBox.Text.ToString() == "" || CurrentQuantityTextBox.Text.ToString() == "")
            {
                MessageBox.Show("Не выбрано наименование или количество");
            }
            else
            {
                ExecuteOperation((int)StoreOperationType.Add, OpTypeDictionary[(int)StoreOperationType.Add]);
                SetDefault();
            }
        }

        private void WriteOffButton_Click(object sender, EventArgs e)
        {
            if (CurrentPositionTextBox.Text.ToString() == "" || CurrentQuantityTextBox.Text.ToString() == "")
            {
                MessageBox.Show("Не выбрано наименование или количество");
            }
            else
            {
                ExecuteOperation((int)StoreOperationType.WriteOff, OpTypeDictionary[(int)StoreOperationType.WriteOff]);
                SetDefault();
            }
        }

        private void SetUser(bool is_admin, string user_name)
        {
            AddPositionButton.Enabled = isAdmin;
            ChangePositionButton.Enabled = false;
            DeletePositionButton.Enabled = false;
            if (isAdmin)
            {
                UserLabel.Text = user_name + "(админстратор)";
            }
            else
            {
                UserLabel.Text = user_name;
            }
        }

        private void UpdateGrids()
        {
            StoreGrid.DataSource = LoadData();
            OperationsGrid.DataSource = LoadData_Operations();
        }

        private void ShowOperationsForInterval_Click(object sender, EventArgs e)
        {
            DateTime DateFrom = StartDateTimePicker.Value.Date;
            DateTime DateTo = EndDateTimePicker.Value.Date;
            OperationsGrid.DataSource = GetOperations(DateFrom, DateTo);
        }

        private DataTable GetOperations(DateTime DateFrom, DateTime DateTo)
        {
            DataTable tbl = new DataTable();
            using (SqlConnection con = new SqlConnection(Connection))
            {
                string cmdStr =
                @"SELECT [id]
                ,[position_id]
                ,[operation_type]
                ,[position]
                ,[quantity]
                ,[price]
                ,[price]
                ,[first_price]
                ,[oper_date]
                FROM [db_Shop].[dbo].[operations]
                where cast(oper_date as date) >= @DateFrom and cast(oper_date as date) <= @DateTo";
                SqlCommand cmd = new SqlCommand(cmdStr, con);
                cmd.Parameters.AddWithValue("@DateFrom", DateFrom);
                cmd.Parameters.AddWithValue("@DateTo", DateTo);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tbl);
            }
            return tbl;
        }

        private void StoreExportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StoreGridView1.Columns.Where(x => x.FieldName == "position" || x.FieldName == "quantity" || x.FieldName == "price" || x.FieldName == "first_price").ToList().ForEach(x => x.Visible = true);
            SaveFileDialog sfd = new SaveFileDialog() { InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), FileName = "Склад " + DateTime.Now.ToString("dd.MM.yyyy HH-m-ss") + ".xlsx" };
            if (sfd.ShowDialog() == DialogResult.OK)
                StoreGridView1.ExportToXlsx(sfd.FileName);
            StoreGridView1.Columns.Where(x => x.FieldName == "first_price").ToList().ForEach(x => x.Visible = false);
        }

        private void OperationExportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OperationsGridView2.Columns.Where(x => x.FieldName == "operation_type" || x.FieldName == "position" || x.FieldName == "quantity" || x.FieldName == "price" || x.FieldName == "first_price" || x.FieldName == "summ_price" || x.FieldName == "oper_date").ToList().ForEach(x => x.Visible = true);
            SaveFileDialog sfd = new SaveFileDialog() { InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), FileName = "Операции " + DateTime.Now.ToString("dd.MM.yyyy HH-m-ss") + ".xlsx" };
            if (sfd.ShowDialog() == DialogResult.OK)
                OperationsGridView2.ExportToXlsx(sfd.FileName);
            OperationsGridView2.Columns.Where(x => x.FieldName == "first_price").ToList().ForEach(x => x.Visible = false);
        }

        private void MakeBackup()
        {
            if (!Directory.Exists(BackupFolderPath))
                Directory.CreateDirectory(BackupFolderPath);

            string backupFileName = BackupFolderPath + "\\" + "db_Shop_" + DateTime.Now.Date.ToString("yyyyMMdd") + ".Bak";
            if (!File.Exists(backupFileName))
                MakeBackupProc(backupFileName);
        }

        private void MakeBackupProc(string fileName)
        {
            using (SqlConnection con = new SqlConnection(Connection))
            {
                con.Open();
                string cmdStr =
                @"BACKUP DATABASE db_Shop  
                TO DISK = @fileName
                ";
                SqlCommand cmd = new SqlCommand(cmdStr, con);
                cmd.Parameters.AddWithValue("@fileName", fileName);
                cmd.ExecuteNonQuery();
            }
        }
 
        private void ChangeUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsersForm usersForm = new UsersForm();

            var (dialogResult, is_Admin, userName) = usersForm.CustomShowDialog();
            usersForm.Close();
            if (dialogResult == DialogResult.OK)
            {
                isAdmin = is_Admin;
                SetUser(isAdmin, userName);
            }
        }

        private void AddPositionButton_Click(object sender, EventArgs e)
        {
            ManageForm manage_form = new ManageForm(0, "", "", "", "", (int)OperationType.Add);
            manage_form.ShowDialog();
            manage_form.Close();
            UpdateGrids();
        }

        private void ChangePositionButton_Click(object sender, EventArgs e)
        {
            DataRowView CurrentRow = StoreGridView1.GetFocusedRow() as DataRowView;
            int CurrentId = Int32.Parse(CurrentRow["id"].ToString());
            string CurrentQuantity = CurrentRow["quantity"].ToString();
            string CurrentPrice = CurrentRow["price"].ToString();
            string CurrentFirstPrice = CurrentRow["first_price"].ToString();
            string CurrentPosition = CurrentRow["position"].ToString();

            ManageForm manage_form = new ManageForm(CurrentId, CurrentPosition, CurrentQuantity, CurrentPrice, CurrentFirstPrice, (int)OperationType.Change);
            manage_form.ShowDialog();
            manage_form.Close();
            UpdateGrids();
        }

        private void DeletePositionButton_Click(object sender, EventArgs e)
        {
            DataRowView CurrentRow = StoreGridView1.GetFocusedRow() as DataRowView;
            int CurrentId = Int32.Parse(CurrentRow["id"].ToString());
            string CurrentQuantity = CurrentRow["quantity"].ToString();
            string CurrentPrice = CurrentRow["price"].ToString();
            string CurrentFirstPrice = CurrentRow["first_price"].ToString();
            string CurrentPosition = CurrentRow["position"].ToString();

            ManageForm manage_form = new ManageForm(CurrentId, CurrentPosition, CurrentQuantity, CurrentPrice, CurrentFirstPrice, (int)OperationType.Delete);
            manage_form.ShowDialog();
            manage_form.Close();
            UpdateGrids();
        }

    }
}
