using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Linq.Expressions;

namespace DB_Library
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void LogButt_Click(object sender, EventArgs e)
        {
            try
            {
                string login = LogTextBox.Text;
                string password = PassTextBox.Text;
                string connectionString = DatabaseConfig.ConnectionString;
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM [UserTub] WHERE [Login] = @Login AND [Password] = @Password";
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Login", login);
                        command.Parameters.AddWithValue("@Password", password);

                        object result = command.ExecuteScalar();
                        int count = (result != null && result != DBNull.Value) ? Convert.ToInt32(result) : 0;

                        if (count > 0)
                        {
                            MessageBox.Show("Добро пожаловать!");
                            GridPage mainForm = new GridPage();
                            mainForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Неверный логин или пароль!");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void RegButt_Click(object sender, EventArgs e)
        {
            RegistPage newFormLater = new RegistPage();
            newFormLater.Show();
            this.Hide();
        }
    }
}