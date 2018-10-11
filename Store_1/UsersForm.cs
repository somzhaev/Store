using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Store_1
{
    public partial class UsersForm : Form
    {
        DataTable usersTbl;
        string Connection = ConfigurationManager.AppSettings.Get("ConString");


        public UsersForm()
        {
            InitializeComponent();
          
        }

        private class vlist
        {
            public int? id { get; set; }

            public string value { get; set; }
            public override string ToString()
            {
                return value.ToString();
            }
        }

        private DataTable getUsers()
        {
            DataTable newTbl = new DataTable();
            using (SqlConnection newCon = new SqlConnection(Connection))
            {
                string cmdStr =
                @"SELECT [user_id]
                ,[user_name]
                ,[password]
                ,[isadmin]
                ,[iskassir]
                ,[status]
                FROM [db_Shop].[dbo].[users]";
                SqlCommand cmd = new SqlCommand(cmdStr, newCon);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(newTbl);
            }
            return newTbl;
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            int user_id = (int)(UserNameComboBox.SelectedItem as vlist).id;
            if (isValidated(user_id, PasswordMaskedTextBox.Text))
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Пароль неверный");
                PasswordMaskedTextBox.Text = "";
            }
        }

        private bool isValidated(int user_id, string password)
        {
            object res;
            using (SqlConnection con = new SqlConnection(Connection))
            {
                con.Open();
                string cmdStr =
                @"declare @res bit = 0
                if(@password = (select [password] from users where [user_id] = @user_id))
	            set @res = 1
                select @res";
                SqlCommand cmd = new SqlCommand(cmdStr, con);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@user_id", user_id);
                res = cmd.ExecuteScalar();
            }
            return (bool)res;
        }

        private bool isValidatedAdmin(int user_id, string password)
        {
            object res;
            using (SqlConnection con = new SqlConnection(Connection))
            {
                con.Open();
                string cmdStr =
                @"declare @res bit = 0
                if(@res < (select [isadmin] from users where [user_id] = @user_id))
	            set @res = 1
                select @res";
                SqlCommand cmd = new SqlCommand(cmdStr, con);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@user_id", user_id);
                res = cmd.ExecuteScalar();
            }
            return (bool)res;
        }

        private void UsersForm_Load(object sender, EventArgs e)
        {
            usersTbl = getUsers();
            var DataCmbBox = (from row in usersTbl.Rows.Cast<DataRow>() select new vlist() { id = (int?)row["user_id"], value = (string)row["user_name"] }).ToList();
            UserNameComboBox.DataSource = DataCmbBox;
        }

        public (DialogResult dialogResult, bool IsAdmin, string UserName) CustomShowDialog()
        {
            DialogResult dialogResult = ShowDialog();
            int user_id = (int)(UserNameComboBox.SelectedItem as vlist).id;
            return (dialogResult, isValidatedAdmin(user_id, PasswordMaskedTextBox.Text), UserNameComboBox.Text);
        }
    }
}
