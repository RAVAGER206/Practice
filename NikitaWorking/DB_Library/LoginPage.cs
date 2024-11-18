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
            RegistPage newForm = new RegistPage(this);
            newForm.Show();
        }

        private void RegButt_Click(object sender, EventArgs e)
        {
            RegistPage newFormLater = new RegistPage();
            newFormLater.Show();
        }
    }
}
