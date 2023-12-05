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
    public partial class Form1 : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\AppData\Tooded.mdf;Integrated Security=True");

        SqlDataAdapter adapter_toode, adapter_kategooria;
        SqlCommand command;

        SaveFileDialog save;
        OpenFileDialog open;

        int Id;
        public Form1()
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

            comboBox1.MaxDropDownItems = dt_Kategooria.Rows.Count; // Устанавливаем максимальное количество элементов

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
                    open.InitialDirectory = @"C:\Users\opilane\source\repos\TARpv22_Maksim_Tsepelevits\Tooded_AB\bin\Debug";
                    open.Multiselect = false;
                    open.Filter = "Images Files(*.jpeg;*.png;*.jpg;*.bmp)|*.jpeg;*.png;*.jpg;*.bmp";

                    if (open.ShowDialog() == DialogResult.OK)
                    {
                        connect.Open();

                        command = new SqlCommand("SELECT Id FROM Kategooriatable WHERE Kategooria_nimetus=@kat", connect);
                        command.Parameters.AddWithValue("@kat", comboBox1.Text);
                        command.ExecuteNonQuery();
                        Id = Convert.ToInt32(command.ExecuteScalar());

                        string imageFileName = Path.GetFileName(open.FileName);

                        Toode_pb.Image = null;

                        string imageDestinationPath = Path.Combine(@"C:\Users\opilane\source\repos\TARpv22_Maksim_Tsepelevits\Tooded_AB\bin\Debug\Images", imageFileName);
                        File.Copy(open.FileName, imageDestinationPath, true);

                        command = new SqlCommand("INSERT INTO Toodetable (Toodenimetus, Kogus, Hind, Pilt, Kategooria) VALUES" +
                        " (@toode, @kogus, @hind, @pilt, @kat)", connect);
                        command.Parameters.AddWithValue("@toode", Toode_txt.Text);
                        command.Parameters.AddWithValue("@kogus", Kogus_txt.Text);
                        command.Parameters.AddWithValue("@hind", Hind_txt.Text);
                        command.Parameters.AddWithValue("@pilt", imageFileName);
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

        private void MuudaKategooriat(int toodeId, int uusKategooriaId)
        {
            connect.Open();
            SqlCommand updateCommand = new SqlCommand("UPDATE Toodetable SET Kategooria = @uusKategooria WHERE Id = @toodeId", connect);
            updateCommand.Parameters.AddWithValue("@uusKategooria", uusKategooriaId);
            updateCommand.Parameters.AddWithValue("@toodeId", toodeId);
            updateCommand.ExecuteNonQuery();
            connect.Close();
        }

        private void Muuda_btn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0 && comboBox1.SelectedItem != null)
            {
                int selectedRowIndex = dataGridView1.SelectedRows[0].Index;
                int selectedToodeId = Convert.ToInt32(dataGridView1.Rows[selectedRowIndex].Cells["Id"].Value);

                string selectedKategooria = comboBox1.SelectedItem.ToString();

                connect.Open();
                SqlCommand command = new SqlCommand("SELECT Id FROM Kategooriatable WHERE Kategooria_nimetus=@kat", connect);
                command.Parameters.AddWithValue("@kat", selectedKategooria);
                int selectedKategooriaId = Convert.ToInt32(command.ExecuteScalar());
                connect.Close();

                MuudaKategooriat(selectedToodeId, selectedKategooriaId);

                NaitaAndmed();
            }
            else
            {
                MessageBox.Show("Valige rida ja uus kategooria!");
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
                string imagePath = Path.Combine(@"C:\Users\opilane\source\repos\TARpv22_Maksim_Tsepelevits\Tooded_AB\bin\Debug\Images", imageName);

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
