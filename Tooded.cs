using Aspose.Pdf.LogicalStructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Tooded_AB
{
    public partial class Tooded : Form
    {

        SqlConnection connect = new SqlConnection(@"Data Source=HP-CZC2349HTF;Initial Catalog=Tooded;Integrated Security=True");

        SqlCommand command;

        PictureBox pb_reklaam;
        SqlDataAdapter adapter_toode, adapter_kategooria;

        public Tooded()
        {
            InitializeComponent();
            Reklaam();
            NaitaAndmed();
            NaitaKategooriad();

            Kat_Box.SelectedIndexChanged += Kat_Box_SelectedIndexChanged;
        }
        private void Reklaam()
        {
            pb_reklaam = new PictureBox();
            pb_reklaam.Image = new Bitmap(@"C:\Users\opilane\source\repos\TARpv22_Maksim_Tsepelevits\Tooded_AB\bin\Debug\reklaam.png");
            pb_reklaam.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_reklaam.Location = new Point(785, 30);
            pb_reklaam.ClientSize = new Size(180, 575);

            Controls.Add(pb_reklaam);
        }

        private DataTable dt_Toode = new DataTable();

        public void NaitaAndmed()
        {
            LoadProducts("");
        }

        private void Kat_Box_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCategory = Kat_Box.SelectedItem?.ToString();


            LoadProducts(selectedCategory);
        }

        private void LoadProducts(string selectedCategory)
        {
            connect.Open();

            dt_Toode.Clear();

            string sqlQuery = "SELECT T.Id, T.Toodenimetus, T.Kogus, T.Hind, T.Pilt, K.Kategooria_nimetus as Kategooria " +
                              "FROM Toodetable T INNER JOIN Kategooriatable K ON T.Kategooria = K.Id " +
                              "WHERE K.Kategooria_nimetus LIKE @SelectedCategory";

            using (SqlCommand command = new SqlCommand(sqlQuery, connect))
            {
                command.Parameters.AddWithValue("@SelectedCategory", $"%{selectedCategory}%");

                adapter_toode = new SqlDataAdapter(command);
                adapter_toode.Fill(dt_Toode);

            }

            lisa_box.DisplayMember = "Toodenimetus";
            lisa_box.ValueMember = "Id";
            lisa_box.DataSource = dt_Toode;

            connect.Close();
        }


        private void NaitaKategooriad()
        {
            connect.Open();
            DataTable dt_Kategooria = new DataTable();
            adapter_kategooria = new SqlDataAdapter("SELECT * FROM Kategooriatable", connect);
            adapter_kategooria.Fill(dt_Kategooria);

            Kat_Box.MaxDropDownItems = dt_Kategooria.Rows.Count;

            foreach (DataRow item in dt_Kategooria.Rows)
            {
                Kat_Box.Items.Add(item["Kategooria_nimetus"].ToString().Trim());
            }

            connect.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void add_item_btn_Click(object sender, EventArgs e)
        {
            if (lisa_box.SelectedItem != null)
            {
                DataRowView selectedItem = (DataRowView)lisa_box.SelectedItem;

                eemalda_box.Items.Add(selectedItem["Toodenimetus"]);
            }
        }

        private void delete_item_btn_Click(object sender, EventArgs e)
        {
            if (eemalda_box.SelectedItem != null)
            {
                string selectedString = eemalda_box.SelectedItem.ToString();

                eemalda_box.Items.Remove(selectedString);
            }
        }



        private void eemalda_box_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void toode_pic_Click(object sender, EventArgs e)
        {

        }

        private void kassa_btn_Click(object sender, EventArgs e)
        {
            Close();
            Kassa KassaForm = new Kassa();
            KassaForm.Show();
        }
    }
}
