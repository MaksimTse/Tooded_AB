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
    public partial class Admin : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\AppData\Tooded.mdf;Integrated Security=True");

        SqlDataAdapter adapter_toode, adapter_kategooria;
        SqlCommand command;

        SaveFileDialog save;
        OpenFileDialog open;

        int Id;
        public Admin()
        {
            InitializeComponent();
            NaitaAndmed();
            NaitaKategooriad();

            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
        }

        public void NaitaAndmed()
        {
            connect.Open();
            DataTable dt_Toode = new DataTable();

            adapter_toode = new SqlDataAdapter("SELECT T.Id, T.Toodenimetus, T.Kogus, T.Hind, T.Pilt, K.Kategooria_nimetus as Kategooria " +
                "FROM Toodetable T INNER JOIN Kategooriatable K ON T.Kategooria = K.Id", connect);
            adapter_toode.Fill(dt_Toode);
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = dt_Toode;
            DataGridViewComboBoxColumn combo_kat = new DataGridViewComboBoxColumn();
            combo_kat.HeaderText = "Kategooria";
            combo_kat.Name = "KategooriaColumn";
            combo_kat.DataPropertyName = "Kategooria";
            HashSet<string> uniqueCategories = new HashSet<string>();
            foreach (DataRow item in dt_Toode.Rows)
            {
                string category = item["Kategooria"].ToString();
                if (!uniqueCategories.Contains(category))
                {
                    uniqueCategories.Add(category);
                    combo_kat.Items.Add(category);
                }
            }
            dataGridView1.Columns.Add(combo_kat);
            dataGridView1.Columns["Kategooria"].Visible = false;
                       
            
            connect.Close();
        }
        private void NaitaKategooriad()
        {
            connect.Open();
            DataTable dt_Kategooria = new DataTable();
            adapter_kategooria = new SqlDataAdapter("SELECT * FROM Kategooriatable", connect);
            adapter_kategooria.Fill(dt_Kategooria);

            comboBox1.MaxDropDownItems = dt_Kategooria.Rows.Count;

            foreach (DataRow item in dt_Kategooria.Rows)
            {
                comboBox1.Items.Add(item["Kategooria_nimetus"].ToString().Trim());
            }

            connect.Close();
        }


        private void Lisa_Kat_btn_Click(object sender, EventArgs e)
        {
            string newCategory = comboBox1.Text.Trim();

            if (!string.IsNullOrEmpty(newCategory) && !KategooriaExists(newCategory))
            {
                try
                {
                    connect.Open();
                    command = new SqlCommand("INSERT INTO Kategooriatable (Kategooria_nimetus) VALUES (@kat)", connect);
                    command.Parameters.AddWithValue("@kat", newCategory);
                    command.ExecuteNonQuery();
                    connect.Close();
                    comboBox1.Items.Clear();
                    NaitaKategooriad();
                }
                catch (Exception)
                {
                    MessageBox.Show("Andmebaasiga viga!");
                }
            }
            else
            {
                MessageBox.Show("Kategooria on juba olemas või sisestatud andmed on puudulikud!");
            }
        }

        private bool KategooriaExists(string categoryName)
        {
            connect.Open();
            SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM Kategooriatable WHERE Kategooria_nimetus = @kat", connect);
            command.Parameters.AddWithValue("@kat", categoryName);
            int count = (int)command.ExecuteScalar();
            connect.Close();

            return count > 0;
        }

        private void Kustuta_Kat_btn_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedItem != null) 
            { 
                string val_kat = comboBox1.SelectedItem.ToString();

                connect.Open();
                SqlCommand command = new SqlCommand("DELETE FROM Kategooriatable WHERE Kategooria_nimetus = @kat", connect);
                command.Parameters.AddWithValue("@kat", val_kat);
                command.ExecuteNonQuery();
                connect.Close();
                comboBox1.Items.Clear();
                NaitaKategooriad();
            }

        }

        private void Lisa_btn_Click(object sender, EventArgs e)
        {
            if (Toode_txt.Text.Trim() != string.Empty && Kogus_txt.Text.Trim() != string.Empty && Hind_txt.Text.Trim() != string.Empty && comboBox1.SelectedItem != null)
            {
                try
                {
                    open = new OpenFileDialog();
                    open.Multiselect = false;
                    open.Filter = "Images Files(*.jpeg;*.png;*.jpg;*.bmp)|*.jpeg;*.png;*.jpg;*.bmp";

                    if (open.ShowDialog() == DialogResult.OK)
                    {
                        connect.Open();

                        command = new SqlCommand("SELECT Id FROM Kategooriatable WHERE Kategooria_nimetus=@kat", connect);
                        command.Parameters.AddWithValue("@kat", comboBox1.Text);
                        command.ExecuteNonQuery();
                        Id = Convert.ToInt32(command.ExecuteScalar());

                        string imagePath = open.FileName;
                        string imageName = Path.GetFileName(imagePath);

                        Toode_pb.Image = Image.FromFile(imagePath);

                        command = new SqlCommand("INSERT INTO Toodetable (Toodenimetus, Kogus, Hind, Pilt, Kategooria) VALUES" +
                        " (@toode, @kogus, @hind, @pilt, @kat)", connect);
                        command.Parameters.AddWithValue("@toode", Toode_txt.Text);
                        command.Parameters.AddWithValue("@kogus", Kogus_txt.Text);
                        command.Parameters.AddWithValue("@hind", Hind_txt.Text);
                        command.Parameters.AddWithValue("@pilt", imageName);
                        command.Parameters.AddWithValue("@kat", Id);

                        command.ExecuteNonQuery();

                        connect.Close();

                        NaitaAndmed();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Andmebaasiga viga: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Sisesta andmeid!");
            }
        }

        private void MuudaToode(int toodeId, string uusToodeNimetus, int uusKogus, decimal uusHind, string uusPilt, int uusKategooriaId)
        {
            connect.Open();
            SqlCommand updateCommand = new SqlCommand("UPDATE Toodetable SET Toodenimetus = @uusToodeNimetus, Kogus = @uusKogus, Hind = @uusHind, Pilt = @uusPilt, Kategooria = @uusKategooria WHERE Id = @toodeId", connect);
            updateCommand.Parameters.AddWithValue("@uusToodeNimetus", uusToodeNimetus);
            updateCommand.Parameters.AddWithValue("@uusKogus", uusKogus);
            updateCommand.Parameters.AddWithValue("@uusHind", uusHind);
            updateCommand.Parameters.AddWithValue("@uusPilt", uusPilt);
            updateCommand.Parameters.AddWithValue("@uusKategooria", uusKategooriaId);
            updateCommand.Parameters.AddWithValue("@toodeId", toodeId);
            updateCommand.ExecuteNonQuery();
            connect.Close();
        }

        private void Muuda_btn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow val_rida = dataGridView1.SelectedRows[0];
                int val_rida_ID = Convert.ToInt32(val_rida.Cells["Id"].Value);

                if (Toode_txt.Text.Trim() != string.Empty && Kogus_txt.Text.Trim() != string.Empty && Hind_txt.Text.Trim() != string.Empty && comboBox1.SelectedItem != null)
                {
                    OpenFileDialog open = new OpenFileDialog();
                    open.InitialDirectory = @"..\..\Images";
                    open.Multiselect = false;
                    open.Filter = "Images Files(*.jpeg;*.png;*.jpg;*.bmp)|*.jpeg;*.png;*.jpg;*.bmp";

                    if (open.ShowDialog() == DialogResult.OK)
                    {
                        string imageFileName = Path.GetFileName(open.FileName);

                        string UUS_ToodeNimetus = Toode_txt.Text;
                        int UUS_Kogus = int.Parse(Kogus_txt.Text);
                        float UUS_Hind = float.Parse(Hind_txt.Text);
                        string UUS_Pilt = imageFileName;
                        string UUS_Kategooria = comboBox1.SelectedItem.ToString();

                        try
                        {
                            if (connect.State == ConnectionState.Closed)
                            {
                                connect.Open();
                            }
                            command = new SqlCommand("SELECT Id FROM Kategooriatable WHERE Kategooria_nimetus = @kat", connect);
                            command.Parameters.AddWithValue("@kat", UUS_Kategooria);
                            int kategooriaId = Convert.ToInt32(command.ExecuteScalar());

                            command = new SqlCommand("UPDATE Toodetable SET Toodenimetus = @toode, Kogus = @kog, Hind = @pc, Pilt = @pilt, Kategooria = @katID WHERE Id = @id", connect);
                            command.Parameters.AddWithValue("@toode", UUS_ToodeNimetus);
                            command.Parameters.AddWithValue("@kog", UUS_Kogus);
                            command.Parameters.AddWithValue("@pc", UUS_Hind);
                            command.Parameters.AddWithValue("@pilt", UUS_Pilt);
                            command.Parameters.AddWithValue("@katID", kategooriaId);
                            command.Parameters.AddWithValue("@id", val_rida_ID);

                            command.ExecuteNonQuery();
                            connect.Close();
                            NaitaAndmed();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Probleem tekkis uuendamisel: " + ex.Message);
                        }
                        finally
                        {
                            if (connect.State == ConnectionState.Open)
                            {
                                connect.Close();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vali pilt!");
                    }
                }
                else
                {
                    MessageBox.Show("Sisesta andmed!");
                }
            }
            else
            {
                MessageBox.Show("Vali rida DataGridView-l uuendamiseks.");
            }
        }

        private void KustutaAndmed(int toodeId)
        {
            connect.Open();
            SqlCommand deleteCommand = new SqlCommand("DELETE FROM Toodetable WHERE Id = @toodeId", connect);
            deleteCommand.Parameters.AddWithValue("@toodeId", toodeId);
            deleteCommand.ExecuteNonQuery();
            connect.Close();
        }

        private void Kustuta_btn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGridView1.SelectedRows[0].Index;
                int selectedToodeId = Convert.ToInt32(dataGridView1.Rows[selectedRowIndex].Cells["Id"].Value);

                KustutaAndmed(selectedToodeId);

                NaitaAndmed();
            }
            else
            {
                MessageBox.Show("Valige rida, mida soovite kustutada!");
            }
        }
        private void otsi_fail_btn_Click(object sender, EventArgs e)
        {
            open = new OpenFileDialog();
            open.InitialDirectory = @"C:\Users\opilane\source\repos\TARpv22_Maksim_Tsepelevits\Tooded_AB\bin\Debug";
            open.Multiselect = true;
            open.Filter = "Images Files(*.jpeg;*.png;*.jpg;*.bmp)|*jpeg;*.png;*.jpg;*.bmp";


            FileInfo open_info = new FileInfo(@"C:\Users\opilane\source\repos\TARpv22_Maksim_Tsepelevits\Tooded_AB\bin\Debug\" + open.FileName);
            if (open.ShowDialog()==DialogResult.OK && Toode_txt.Text != null)
            {
                save = new SaveFileDialog();
                save.InitialDirectory = Path.GetFullPath(@"..\..\Images");
                save.FileName = Toode_txt.Text + Path.GetExtension(open.FileName);
                save.Filter = "Images" + Path.GetExtension(open.FileName)+"|"+Path.GetExtension(open.FileName);
                if (save.ShowDialog() == DialogResult.OK)
                {
                    File.Copy(open.FileName, save.FileName);
                    Image img = Image.FromFile(save.FileName);
                    Toode_pb.SizeMode = PictureBoxSizeMode.StretchImage;
                    Toode_pb.ClientSize = new Size(200, 200);
                    Toode_pb.Image = (Image)(new Bitmap(img, Toode_pb.ClientSize));
                }
            }
            else
            {
                MessageBox.Show("Puudub toode nimetus või oli vajutatud Cancel");
            }

            open.ShowDialog();
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string imageName = dataGridView1.SelectedRows[0].Cells["Pilt"].Value.ToString();
                string imagePath = Path.Combine(Path.GetFullPath(@"..\..\Images"), imageName);

                if (File.Exists(imagePath))
                {
                    Image img = Image.FromFile(imagePath);

                    Toode_pb.SizeMode = PictureBoxSizeMode.StretchImage;
                    Toode_pb.ClientSize = new Size(200, 200);
                    Toode_pb.Image = (Image)(new Bitmap(img, Toode_pb.ClientSize));
                }
                else
                {
                    MessageBox.Show($"Image file '{imageName}' not found.");
                }
            }
            else
            {
                Toode_pb.Image = null;
            }
        }


    }
}
