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

namespace Tooded_AB
{
    public partial class Main : Form
    {
        PictureBox pb_logo;
        public Main()
        {
            InitializeComponent();
            Logo();
        }

        private void Logo()
        {
            pb_logo = new PictureBox();
            pb_logo.Image = new Bitmap(@"C:\Users\opilane\source\repos\TARpv22_Maksim_Tsepelevits\Tooded_AB\bin\Debug\maxima.png");
            pb_logo.SizeMode= PictureBoxSizeMode.StretchImage;
            pb_logo.Location = new Point(176, 56);
            pb_logo.ClientSize = new Size(450, 150);

            Controls.Add(pb_logo);
        }

        private void Login_btn_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
        }

        private void Reg_btn_Click(object sender, EventArgs e)
        {
            Register regForm = new Register();
            regForm.Show();
        }

        private void Pood_btn_Click(object sender, EventArgs e) 
        {
            Tooded poodForm = new Tooded();
            poodForm.Show();
        }


        private void exit_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
