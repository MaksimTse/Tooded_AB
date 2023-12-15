using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Tooded_AB
{
    public partial class Login : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=HP-CZC2349HTF;Initial Catalog=Tooded;Integrated Security=True");

        SqlCommand command;

        public Login()
        {
            InitializeComponent();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            string username = Nimi_box.Text.Trim();
            string password = Pass_box.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                connect.Open();

                string query = "SELECT COUNT(*) FROM Klient WHERE Nimi = @Nimi AND Password = @Password";
                command = new SqlCommand(query, connect);

                // Add parameters to prevent SQL injection
                command.Parameters.AddWithValue("@Nimi", username);
                command.Parameters.AddWithValue("@Password", password);

                int count = (int)command.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Add code to navigate to the main application or perform other actions upon successful login
                }
                else
                {
                    MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connect.Close();
            }
        }
    }
}
