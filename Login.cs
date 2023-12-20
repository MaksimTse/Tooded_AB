using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Tooded_AB
{
    public partial class Login : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=HP-CZC2349HTF;Initial Catalog=Tooded;Integrated Security=True");

        SqlCommand command;
        bool login = false;
        public Login()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            string enteredName = name.Text;
            string enteredPassword = PassLogin.Text;

            if (enteredName == "Admin" && enteredPassword == "Admin") // Замените "AdminPassword" на фактический пароль администратора
            {
                Close();
                Admin adminForm = new Admin();
                adminForm.Show();
            }
            else
            {
                string query = $"SELECT * FROM Klient WHERE Nimi = '{enteredName}' AND CONVERT(NVARCHAR(MAX), Password) = '{enteredPassword}'";

                using (SqlCommand command = new SqlCommand(query, connect))
                {
                    connect.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        login = true;
                        Close();
                        Tooded poodForm = new Tooded();
                        poodForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Vale kasutajanimi või salasõna");
                    }

                    connect.Close();
                }
            }
        }

    }
}
