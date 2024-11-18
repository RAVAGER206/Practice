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
            string login = LogTextBox.Text;   // Получаем текст из поля логина
            string password = PassTextBox.Text; // Получаем текст из поля пароля

            // Подключаемся к базе данных и проверяем логин и пароль
            string connectionString = DatabaseConfig.ConnectionString;
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open(); // Открываем соединение с базой данных

                // Запрос для поиска пользователя по логину и паролю
                string query = "SELECT COUNT(*) FROM User WHERE Login = ? AND Password = ?";
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    // Добавляем параметры для предотвращения SQL инъекций
                    command.Parameters.AddWithValue("?", login);
                    command.Parameters.AddWithValue("?", password);

                    // Выполняем запрос и получаем количество строк (если больше 0, значит, пользователь найден)
                    int result = Convert.ToInt32(command.ExecuteScalar());

                    if (result > 0) // Если пользователь найден
                    {
                        MessageBox.Show("Добро пожаловать!");
                        RegistPage mainForm = new RegistPage(); // Открываем основное окно
                        mainForm.Show();
                        this.Hide(); // Скрываем форму входа
                    }
                    else // Если логин и пароль не совпадают
                    {
                        MessageBox.Show("Неверный логин или пароль!");
                    }
                }
            }
        }

        private void RegButt_Click(object sender, EventArgs e)
        {
            RegistPage newFormLater = new RegistPage();
            newFormLater.Show();
        }
    }
}