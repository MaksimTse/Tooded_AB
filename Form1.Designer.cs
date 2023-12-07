namespace Tooded_AB
{
    partial class Admin
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Toode_pb = new System.Windows.Forms.PictureBox();
            this.Hind_txt = new System.Windows.Forms.TextBox();
            this.Kogus_txt = new System.Windows.Forms.TextBox();
            this.Toode_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.otsi_fail_btn = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.Lisa_Kat_btn = new System.Windows.Forms.Button();
            this.Lisa = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Toode_pb)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(82, 236);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(682, 193);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(85, 193);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 37);
            this.button2.TabIndex = 2;
            this.button2.Text = "Kustuta kategooria";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Kustuta_Kat_btn_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(211, 138);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(90, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // Toode_pb
            // 
            this.Toode_pb.Location = new System.Drawing.Point(524, 12);
            this.Toode_pb.Name = "Toode_pb";
            this.Toode_pb.Size = new System.Drawing.Size(200, 200);
            this.Toode_pb.TabIndex = 4;
            this.Toode_pb.TabStop = false;
            // 
            // Hind_txt
            // 
            this.Hind_txt.Location = new System.Drawing.Point(211, 112);
            this.Hind_txt.Name = "Hind_txt";
            this.Hind_txt.Size = new System.Drawing.Size(90, 20);
            this.Hind_txt.TabIndex = 5;
            // 
            // Kogus_txt
            // 
            this.Kogus_txt.Location = new System.Drawing.Point(211, 86);
            this.Kogus_txt.Name = "Kogus_txt";
            this.Kogus_txt.Size = new System.Drawing.Size(89, 20);
            this.Kogus_txt.TabIndex = 6;
            // 
            // Toode_txt
            // 
            this.Toode_txt.Location = new System.Drawing.Point(211, 60);
            this.Toode_txt.Name = "Toode_txt";
            this.Toode_txt.Size = new System.Drawing.Size(89, 20);
            this.Toode_txt.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Hind";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(126, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Kogus";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(126, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Toode Nimetus";
            // 
            // otsi_fail_btn
            // 
            this.otsi_fail_btn.Location = new System.Drawing.Point(444, 189);
            this.otsi_fail_btn.Name = "otsi_fail_btn";
            this.otsi_fail_btn.Size = new System.Drawing.Size(58, 27);
            this.otsi_fail_btn.TabIndex = 12;
            this.otsi_fail_btn.Text = "Otsi fail";
            this.otsi_fail_btn.UseVisualStyleBackColor = true;
            this.otsi_fail_btn.Click += new System.EventHandler(this.otsi_fail_btn_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(237, 193);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(70, 37);
            this.button5.TabIndex = 14;
            this.button5.Text = "Uuenda";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Muuda_btn_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(313, 193);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(70, 37);
            this.button6.TabIndex = 15;
            this.button6.Text = "Kustuta";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Kustuta_btn_Click);
            // 
            // Lisa_Kat_btn
            // 
            this.Lisa_Kat_btn.Location = new System.Drawing.Point(307, 135);
            this.Lisa_Kat_btn.Name = "Lisa_Kat_btn";
            this.Lisa_Kat_btn.Size = new System.Drawing.Size(88, 25);
            this.Lisa_Kat_btn.TabIndex = 19;
            this.Lisa_Kat_btn.Text = "Lisa kategooria";
            this.Lisa_Kat_btn.UseVisualStyleBackColor = true;
            this.Lisa_Kat_btn.Click += new System.EventHandler(this.Lisa_Kat_btn_Click);
            // 
            // Lisa
            // 
            this.Lisa.Location = new System.Drawing.Point(161, 193);
            this.Lisa.Name = "Lisa";
            this.Lisa.Size = new System.Drawing.Size(70, 37);
            this.Lisa.TabIndex = 20;
            this.Lisa.Text = "Lisa";
            this.Lisa.UseVisualStyleBackColor = true;
            this.Lisa.Click += new System.EventHandler(this.Lisa_btn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(126, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Kategooria";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Lisa);
            this.Controls.Add(this.Lisa_Kat_btn);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.otsi_fail_btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Toode_txt);
            this.Controls.Add(this.Kogus_txt);
            this.Controls.Add(this.Hind_txt);
            this.Controls.Add(this.Toode_pb);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Toode_pb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox Toode_pb;
        private System.Windows.Forms.TextBox Hind_txt;
        private System.Windows.Forms.TextBox Kogus_txt;
        private System.Windows.Forms.TextBox Toode_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button otsi_fail_btn;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button Lisa_Kat_btn;
        private System.Windows.Forms.Button Lisa;
        private System.Windows.Forms.Label label5;
    }
}

