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

namespace Tooded_AB
{
    public partial class Tooded : Form
    {
        PictureBox pb_reklaam;
        public Tooded()
        {
            InitializeComponent();
            Reklaam();
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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
