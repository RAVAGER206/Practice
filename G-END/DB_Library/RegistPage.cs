using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_Library
{
    public partial class RegistPage : Form
    {
        public RegistPage()
        {
            InitializeComponent();
        }

        private void RegButt2_Click(object sender, EventArgs e)
        {

            try
            {
                string role = RoleBar.Text.Trim();
                string nameUser = NameBar.Text.Trim();
                string login = LoginBar.Text.Trim();
                string password = PasswordBar.Text.Trim();

                if (string.IsNullOrWhiteSpace(role) || string.IsNullOrWhiteSpace(nameUser) 
                    || string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(password))
                {
                    MessageBox.Show("Все поля должны быть заполнены!");
                    return;
                }

                string connectionString = DatabaseConfig.ConnectionString;

                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();

                    string checkQuery = "SELECT COUNT(*) FROM [UserTub] WHERE [Login] = ?";
                    using (OleDbCommand checkCommand = new OleDbCommand(checkQuery, connection))
                    {
                        checkCommand.Parameters.AddWithValue("?", login);
                        object checkResult = checkCommand.ExecuteScalar();
                        int userExists = (checkResult != null && checkResult != DBNull.Value) ? Convert.ToInt32(checkResult) : 0;

                        if (userExists > 0)
                        {
                            MessageBox.Show("Пользователь с таким логином уже существует!");
                            return;
                        }
                    }

                    string insertQuery = "INSERT INTO [UserTub] ([IdUserRole], [NameUser], [Login], [Password]) VALUES (?, ?, ?, ?)";
                    using (OleDbCommand insertCommand = new OleDbCommand(insertQuery, connection))
                    {
                        insertCommand.Parameters.AddWithValue("?", role);
                        insertCommand.Parameters.AddWithValue("?", nameUser);
                        insertCommand.Parameters.AddWithValue("?", login);
                        insertCommand.Parameters.AddWithValue("?", password);

                        int rowsAffected = insertCommand.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Пользователь успешно зарегистрирован!");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Ошибка при регистрации пользователя!");
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка регистрации! Простите за доставленные неудобства, мы работаем над этим!");
            }
        }

        private void BackButt_Click(object sender, EventArgs e)
        {

        }
    }
}