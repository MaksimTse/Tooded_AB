namespace Tooded_AB
{
    partial class ForgotPass
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
            this.send_email_btn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cancel_email_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // send_email_btn
            // 
            this.send_email_btn.BackColor = System.Drawing.Color.MediumAquamarine;
            this.send_email_btn.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.send_email_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.send_email_btn.Location = new System.Drawing.Point(320, 249);
            this.send_email_btn.Name = "send_email_btn";
            this.send_email_btn.Size = new System.Drawing.Size(158, 49);
            this.send_email_btn.TabIndex = 0;
            this.send_email_btn.Text = "Saada";
            this.send_email_btn.UseVisualStyleBackColor = false;
            this.send_email_btn.Click += new System.EventHandler(this.send_email_btn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(259, 189);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(260, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(653, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sisestage oma e-posti aadress ja kui teil on meie poes konto,";
            this.label1.UseMnemonic = false;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(190, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(437, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = " saate e-kirja oma salasõna muutmiseks.";
            this.label2.UseMnemonic = false;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cancel_email_btn
            // 
            this.cancel_email_btn.BackColor = System.Drawing.Color.Crimson;
            this.cancel_email_btn.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_email_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cancel_email_btn.Location = new System.Drawing.Point(362, 304);
            this.cancel_email_btn.Name = "cancel_email_btn";
            this.cancel_email_btn.Size = new System.Drawing.Size(71, 29);
            this.cancel_email_btn.TabIndex = 4;
            this.cancel_email_btn.Text = "Cancel";
            this.cancel_email_btn.UseVisualStyleBackColor = false;
            this.cancel_email_btn.Click += new System.EventHandler(this.cancel_email_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(314, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 35);
            this.label3.TabIndex = 5;
            this.label3.Text = "Taastumine";
            // 
            // ForgotPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cancel_email_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.send_email_btn);
            this.Name = "ForgotPass";
            this.Text = "ForgotPass";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button send_email_btn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cancel_email_btn;
        private System.Windows.Forms.Label label3;
    }
}