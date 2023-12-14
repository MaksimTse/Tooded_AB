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
 
    public partial class Register : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=HP-CZC2349HTF;Initial Catalog=Tooded;Integrated Security=True");

        SqlCommand command;
        public Register()
        {
            InitializeComponent();
            pass_box.UseSystemPasswordChar = true;
            rep_pass_text.UseSystemPasswordChar = true;
        }

        private void AddClientToDatabase(string nimi, string email, string password)
        {
            try
            {
                connect.Open();
                string query = "INSERT INTO Klient (Nimi, Email, Password) VALUES (@Nimi, @Email, @Password)";
                command = new SqlCommand(query, connect);

                // Add parameters to prevent SQL injection
                command.Parameters.AddWithValue("@Nimi", nimi);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Password", password);

                command.ExecuteNonQuery();
                MessageBox.Show("Client added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connect.Close();
            }
            this.Close();
        }

        private void EyeBox_CheckedChanged(object sender, EventArgs e)
        {
            if (EyeBox.Checked) {
                pass_box.UseSystemPasswordChar = false;
                rep_pass_text.UseSystemPasswordChar = false;

            }
            else
            {
                pass_box.UseSystemPasswordChar = true;
                rep_pass_text.UseSystemPasswordChar = true;
            }
        }

        private void reg_btn_Click(object sender, EventArgs e)
        {
            string nimi = nimi_box.Text.Trim();
            string email = email_box.Text.Trim();
            string password = pass_box.Text;

            // Validate that all fields are filled
            if (string.IsNullOrEmpty(nimi) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            AddClientToDatabase(nimi, email, password);

            // Additional logic or UI updates can be added here
            ClearInputFields();
        }

        private void cancel_reg_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearInputFields()
        {
            nimi_box.Clear();
            email_box.Clear();
            pass_box.Clear();
        }

        private void pass_box_TextChanged(object sender, EventArgs e)
        {
            string password = pass_box.Text;

            if (!IsPasswordValid(password))
            {
                MessageBox.Show("Password must meet certain requirements.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                pass_box.Clear();
            }
        }

        private bool IsPasswordValid(string password)
        {
            return password.Length >= 8 &&
                   password.Any(char.IsDigit) &&
                   password.Any(char.IsUpper);
        }
        private void email_box_TextChanged(object sender, EventArgs e)
        {
            string email = email_box.Text;

            if (!email.EndsWith("@gmail.com"))
            {
                MessageBox.Show("Email must end with @gmail.com.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                email_box.Clear();
            }
        }

        private void rep_pass_text_TextChanged(object sender, EventArgs e)
        {
            string password = pass_box.Text;
            string repeatedPassword = rep_pass_text.Text;

            if (password != repeatedPassword)
            {
                MessageBox.Show("Passwords do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                rep_pass_text.Clear();
            }
        }
    }
}
