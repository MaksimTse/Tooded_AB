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
            string repeatedPassword = rep_pass_text.Text;

            // Validate that all fields are filled
            if (string.IsNullOrEmpty(nimi) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(repeatedPassword))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate email format
            if (!email.EndsWith("@gmail.com"))
            {
                MessageBox.Show("Email must end with @gmail.com.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate password requirements
            List<string> passwordErrors = GetPasswordErrors(password);

            if (passwordErrors.Count > 0)
            {
                StringBuilder errorMessage = new StringBuilder();
                errorMessage.AppendLine("Password must meet the following requirements:");
                foreach (string error in passwordErrors)
                {
                    errorMessage.AppendLine("- " + error);
                }

                MessageBox.Show(errorMessage.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                pass_box.Clear();
                return;
            }

            // Validate password match
            if (password != repeatedPassword)
            {
                MessageBox.Show("Passwords do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // All validations passed, add client to the database
            AddClientToDatabase(nimi, email, password);

            Login loginForm = new Login();
            loginForm.Show();


            // Additional logic or UI updates can be added here
            this.Hide();
            ClearInputFields();

        }

        private List<string> GetPasswordErrors(string password)
        {
            List<string> errors = new List<string>();

            if (password.Length < 8)
            {
                errors.Add("Password must be at least 8 characters long.");
            }

            if (!password.Any(char.IsDigit))
            {
                errors.Add("Password must contain at least one digit.");
            }

            if (!password.Any(char.IsUpper))
            {
                errors.Add("Password must contain at least one uppercase letter.");
            }

            return errors;
        }



        private void cancel_reg_btn_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
            
            this.Hide();
        }

        private void ClearInputFields()
        {
            nimi_box.Clear();
            email_box.Clear();
            pass_box.Clear();
        }

        private void pass_box_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
