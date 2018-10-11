using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Store_1
{
    public partial class ManageForm : Form
    {
        string Connection = ConfigurationManager.AppSettings.Get("ConString");
        int t_id;
        int CurOperationType;
        int CurId;

        public ManageForm(int CurrentId, string CurrentPosition, string CurrentQuantity, string CurrentPrice,
            string CurrentFirstPrice, int CurrentOperationType)
        {
            InitializeComponent();
            PostionTextBox.Text = CurrentPosition;
            QuantityTextBox.Text = CurrentQuantity;
            PriceTextBox.Text = CurrentPrice;
            FirstPriceTextBox.Text = CurrentFirstPrice;
            CurOperationType = CurrentOperationType;
            CurId = CurrentId;
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            switch (OperationNameLabel.Text)
            {
                case "ДОБАВЛЕНИЕ ТОВАРА":
                    if (isInfoFilled())
                    {
                        CreateNewPosition();
                        MessageBox.Show("Наименование добавлено");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Поля не заполнены!");
                    }
                    break;
                case "ИЗМЕНЕНИЕ ТОВАРА":
                    if (isInfoFilled())
                    {
                        UpdatePosition();
                        MessageBox.Show("Наименование изменено");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Поля не заполнены!");
                    }
                    break;
                case "УДАЛЕНИЕ ТОВАРА":
                    DeletePosition();
                    MessageBox.Show("Наименование удалено");
                    this.Close();
                    break;

            }
        }

        private void CreateNewPosition()
        {
            int op_quantity = Int32.Parse(QuantityTextBox.Text);
            int op_price = Int32.Parse(PriceTextBox.Text);
            int op_first_price = Int32.Parse(FirstPriceTextBox.Text);
            string op_position = PostionTextBox.Text;



            using (SqlConnection newCon = new SqlConnection(Connection))
            {
                string newProc = @"InsertNewPosition";

                newCon.Open();
                SqlTransaction sqlTran = newCon.BeginTransaction(); /*Начало транзакции*/
                SqlCommand newCommand = new SqlCommand(newProc, newCon);
                newCommand.Transaction = sqlTran; /*добавляем операцию в транзакцию*/

                try
                {
                    newCommand.CommandType = CommandType.StoredProcedure;
                    newCommand.Parameters.AddWithValue("@position", op_position);
                    newCommand.Parameters.AddWithValue("@quantity", op_quantity);
                    newCommand.Parameters.AddWithValue("@price", op_price);
                    newCommand.Parameters.AddWithValue("@first_price", op_first_price);
                    newCommand.ExecuteNonQuery();

                    sqlTran.Commit();
                }
                catch (Exception e)
                {
                    sqlTran.Rollback();
                    Logger.LogText += " Ошибка " + e.Message + " ";
                }
                finally
                {
                    WriteLogText();
                }


            }
        }

        private void UpdatePosition()
        {
            int op_id = t_id;
            int op_quantity = Int32.Parse(QuantityTextBox.Text);
            int op_price = Int32.Parse(PriceTextBox.Text);
            int op_first_price = Int32.Parse(FirstPriceTextBox.Text);
            string op_position = PostionTextBox.Text;



            using (SqlConnection newCon = new SqlConnection(Connection))
            {
                string newProc = @"UpdatePosition";

                newCon.Open();
                SqlTransaction sqlTran = newCon.BeginTransaction(); /*Начало транзакции*/
                SqlCommand newCommand = new SqlCommand(newProc, newCon);
                newCommand.Transaction = sqlTran; /*добавляем операцию в транзакцию*/

                try
                {
                    newCommand.CommandType = CommandType.StoredProcedure;
                    newCommand.Parameters.AddWithValue("@id", op_id);
                    newCommand.Parameters.AddWithValue("@position", op_position);
                    newCommand.Parameters.AddWithValue("@quantity", op_quantity);
                    newCommand.Parameters.AddWithValue("@price", op_price);
                    newCommand.Parameters.AddWithValue("@first_price", op_first_price);
                    newCommand.ExecuteNonQuery();

                    sqlTran.Commit();
                }
                catch (Exception e)
                {
                    sqlTran.Rollback();
                    Logger.LogText += " Ошибка " + e.Message + " ";
                }
                finally
                {
                    WriteLogText();
                }


            }
        }



        private void DeletePosition()
        {
            int op_id = t_id;

            using (SqlConnection newCon = new SqlConnection(Connection))
            {
                string newProc = @"DeletePosition";

                newCon.Open();
                SqlTransaction sqlTran = newCon.BeginTransaction(); /*Начало транзакции*/
                SqlCommand newCommand = new SqlCommand(newProc, newCon);
                newCommand.Transaction = sqlTran; /*добавляем операцию в транзакцию*/

                try
                {
                    newCommand.CommandType = CommandType.StoredProcedure;
                    newCommand.Parameters.AddWithValue("@id", op_id);

                    newCommand.ExecuteNonQuery();

                    sqlTran.Commit();
                }
                catch (Exception e)
                {
                    sqlTran.Rollback();
                    Logger.LogText += " Ошибка " + e.Message + " ";
                }
                finally
                {
                    WriteLogText();
                }


            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SetTexBoxes(bool isFilled)
        {
            PostionTextBox.Enabled = isFilled;
            QuantityTextBox.Enabled = isFilled;
            PriceTextBox.Enabled = isFilled;
            FirstPriceTextBox.Enabled = isFilled;
        }

        private bool isInfoFilled()
        {
            if (PostionTextBox.Text == "" || QuantityTextBox.Text == "" || PriceTextBox.Text == "" ||
                FirstPriceTextBox.Text == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void WriteLogText()
        {
            Logger.LogText += OperationNameLabel.Text + "\r\n " + PositionLabel.Text + " " + PostionTextBox.Text + "\r\n "
                + QuantityLabel.Text + " " + QuantityTextBox.Text + "\r\n "
                + PriceLabel.Text + " " + PriceTextBox.Text + "\r\n "
                + FirstPriceLabel.Text + " " + FirstPriceTextBox.Text;
            Logger.LogWrite(Logger.LogText);

        }

        private void QuantityTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void PriceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void FirstPriceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void ManageForm_Load(object sender, EventArgs e)
        {
            switch (CurOperationType)
            {
                case 1:
                    OperationNameLabel.Text = "ДОБАВЛЕНИЕ ТОВАРА";
                    ConfirmButton.Text = "ПОДТВЕРДИТЬ";
                    SetTexBoxes(true);
                    break;
                case 2:
                    OperationNameLabel.Text = "ИЗМЕНЕНИЕ ТОВАРА";
                    t_id = CurId;
                    ConfirmButton.Text = "ПОДТВЕРДИТЬ";
                    SetTexBoxes(true);
                    break;
                case 3:
                    OperationNameLabel.Text = "УДАЛЕНИЕ ТОВАРА";
                    t_id = CurId;
                    MessageBox.Show("ВНИМАНИЕ! ЭТО ФОРМА УДАЛЕНИЯ ТОВАРА!" +
                        "ПОСЛЕ НАЖАТИЯ КНОПКИ 'УДАЛИТЬ'" +
                        "ТОВАР БУДЕТ УДАЛЕН БЕЗВОЗВРАТНО!");
                    ConfirmButton.Text = "УДАЛИТЬ";
                    SetTexBoxes(false);
                    break;
            }
        }
    }
}
