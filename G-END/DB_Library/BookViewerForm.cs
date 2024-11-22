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
    public partial class BookViewerForm : Form
    {
        public BookViewerForm()
        {
            InitializeComponent();
            LoadBooks(); // Загрузка книг при открытии формы
        }


        private void LoadBooks()
        {
            try
            {
                string connectionString = DatabaseConfig.ConnectionString; // Подключение к БД
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM Books"; // Запрос на получение всех данных
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable); // Заполняем DataTable
                        booksDataGridView.DataSource = dataTable; // Привязываем к DataGridView
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки данных: {ex.Message}");
            }
        }

        private void SearchBooks()
        {
            try
            {
                string title = titleTextBox.Text;
                string author = authorTextBox.Text;
                string genre = genreTextBox.Text;

                string query = "SELECT * FROM Books WHERE 1=1"; // Базовый запрос

                // Добавляем условия к запросу, если поля заполнены
                if (!string.IsNullOrEmpty(title))
                    query += " AND Title LIKE ?";
                if (!string.IsNullOrEmpty(author))
                    query += " AND Author LIKE ?";
                if (!string.IsNullOrEmpty(genre))
                    query += " AND Genre LIKE ?";

                string connectionString = DatabaseConfig.ConnectionString;
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        // Добавляем параметры
                        if (!string.IsNullOrEmpty(title))
                            command.Parameters.AddWithValue("?", $"%{title}%");
                        if (!string.IsNullOrEmpty(author))
                            command.Parameters.AddWithValue("?", $"%{author}%");
                        if (!string.IsNullOrEmpty(genre))
                            command.Parameters.AddWithValue("?", $"%{genre}%");

                        using (OleDbDataAdapter adapter = new OleDbDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            booksDataGridView.DataSource = dataTable; // Обновляем DataGridView
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка поиска книг: {ex.Message}");
            }
        }

        private void AddBook()
        {
            try
            {
                string title = titleTextBox.Text;
                string author = authorTextBox.Text;
                string genre = genreTextBox.Text;
                string year = yearTextBox.Text;
                string description = descriptionTextBox.Text;

                string connectionString = DatabaseConfig.ConnectionString;
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO Books (Title, Author, Genre, YearOfPublication, Discription) VALUES (?, ?, ?, ?, ?)";
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("?", title);
                        command.Parameters.AddWithValue("?", author);
                        command.Parameters.AddWithValue("?", genre);
                        command.Parameters.AddWithValue("?", year);
                        command.Parameters.AddWithValue("?", description);

                        int rowsAffected = command.ExecuteNonQuery(); // Выполняем запрос
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Книга успешно добавлена!");
                            LoadBooks(); // Обновляем список книг
                        }
                        else
                        {
                            MessageBox.Show("Не удалось добавить книгу.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка добавления книги: {ex.Message}");
            }
        }

        private void BookViewerForm_Load(object sender, EventArgs e)
        {
            this.booksTableAdapter.Fill(this.libBDDataSet.Books);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            SearchBooks();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddBook();
        }

        private void booksDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
