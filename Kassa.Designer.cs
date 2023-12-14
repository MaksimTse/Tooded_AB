namespace Tooded_AB
{
    partial class Kassa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lisainfo_box = new System.Windows.Forms.TextBox();
            this.aadress_box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ostukorvi_box = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.telefon_box = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nimi_box = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(565, 342);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 60);
            this.button1.TabIndex = 0;
            this.button1.Text = "Tellimus";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(358, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kassa";
            // 
            // lisainfo_box
            // 
            this.lisainfo_box.Location = new System.Drawing.Point(49, 206);
            this.lisainfo_box.Name = "lisainfo_box";
            this.lisainfo_box.Size = new System.Drawing.Size(211, 20);
            this.lisainfo_box.TabIndex = 2;
            // 
            // aadress_box
            // 
            this.aadress_box.Location = new System.Drawing.Point(49, 151);
            this.aadress_box.Name = "aadress_box";
            this.aadress_box.Size = new System.Drawing.Size(211, 20);
            this.aadress_box.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label2.Location = new System.Drawing.Point(46, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Aadress:";
            // 
            // ostukorvi_box
            // 
            this.ostukorvi_box.FormattingEnabled = true;
            this.ostukorvi_box.Location = new System.Drawing.Point(552, 78);
            this.ostukorvi_box.Name = "ostukorvi_box";
            this.ostukorvi_box.Size = new System.Drawing.Size(210, 212);
            this.ostukorvi_box.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label3.Location = new System.Drawing.Point(46, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Lisainfo (sissepääs, korrus, korter):";
            // 
            // telefon_box
            // 
            this.telefon_box.Location = new System.Drawing.Point(48, 261);
            this.telefon_box.Name = "telefon_box";
            this.telefon_box.Size = new System.Drawing.Size(211, 20);
            this.telefon_box.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label4.Location = new System.Drawing.Point(45, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Telefoninumber:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label5.Location = new System.Drawing.Point(46, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Nimi:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // nimi_box
            // 
            this.nimi_box.Location = new System.Drawing.Point(49, 97);
            this.nimi_box.Name = "nimi_box";
            this.nimi_box.Size = new System.Drawing.Size(211, 20);
            this.nimi_box.TabIndex = 9;
            this.nimi_box.TextChanged += new System.EventHandler(this.nimi_box_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(49, 321);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(453, 108);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Kassa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nimi_box);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.telefon_box);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ostukorvi_box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.aadress_box);
            this.Controls.Add(this.lisainfo_box);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Kassa";
            this.Text = "Kassa";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lisainfo_box;
        private System.Windows.Forms.TextBox aadress_box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox ostukorvi_box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox telefon_box;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nimi_box;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}