namespace Tooded_AB
{
    partial class Register
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nimi_box = new System.Windows.Forms.TextBox();
            this.pass_box = new System.Windows.Forms.TextBox();
            this.rep_pass_text = new System.Windows.Forms.TextBox();
            this.email_box = new System.Windows.Forms.TextBox();
            this.email_txt = new System.Windows.Forms.Label();
            this.reg_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cancel_reg_btn = new System.Windows.Forms.Button();
            this.EyeBox = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(247, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 23);
            this.label2.TabIndex = 25;
            this.label2.Text = "Kasutaja nimi";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(247, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 23);
            this.label3.TabIndex = 27;
            this.label3.Text = "Korda salasõna";
            // 
            // nimi_box
            // 
            this.nimi_box.Location = new System.Drawing.Point(251, 114);
            this.nimi_box.Name = "nimi_box";
            this.nimi_box.Size = new System.Drawing.Size(267, 20);
            this.nimi_box.TabIndex = 28;
            // 
            // pass_box
            // 
            this.pass_box.Location = new System.Drawing.Point(251, 212);
            this.pass_box.Name = "pass_box";
            this.pass_box.Size = new System.Drawing.Size(267, 20);
            this.pass_box.TabIndex = 29;
            this.pass_box.TextChanged += new System.EventHandler(this.pass_box_TextChanged);
            // 
            // rep_pass_text
            // 
            this.rep_pass_text.Location = new System.Drawing.Point(251, 268);
            this.rep_pass_text.Name = "rep_pass_text";
            this.rep_pass_text.Size = new System.Drawing.Size(267, 20);
            this.rep_pass_text.TabIndex = 30;
            this.rep_pass_text.TextChanged += new System.EventHandler(this.rep_pass_text_TextChanged);
            // 
            // email_box
            // 
            this.email_box.Location = new System.Drawing.Point(251, 163);
            this.email_box.Name = "email_box";
            this.email_box.Size = new System.Drawing.Size(267, 20);
            this.email_box.TabIndex = 31;
            this.email_box.TextChanged += new System.EventHandler(this.email_box_TextChanged);
            // 
            // email_txt
            // 
            this.email_txt.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_txt.Location = new System.Drawing.Point(247, 137);
            this.email_txt.Name = "email_txt";
            this.email_txt.Size = new System.Drawing.Size(146, 23);
            this.email_txt.TabIndex = 32;
            this.email_txt.Text = "E-mail";
            // 
            // reg_btn
            // 
            this.reg_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.reg_btn.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.reg_btn.Location = new System.Drawing.Point(279, 317);
            this.reg_btn.Name = "reg_btn";
            this.reg_btn.Size = new System.Drawing.Size(209, 49);
            this.reg_btn.TabIndex = 33;
            this.reg_btn.Text = "Registreeri";
            this.reg_btn.UseVisualStyleBackColor = false;
            this.reg_btn.Click += new System.EventHandler(this.reg_btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(273, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(216, 35);
            this.label4.TabIndex = 34;
            this.label4.Text = "Registreerimine";
            // 
            // cancel_reg_btn
            // 
            this.cancel_reg_btn.BackColor = System.Drawing.Color.Crimson;
            this.cancel_reg_btn.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_reg_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cancel_reg_btn.Location = new System.Drawing.Point(345, 372);
            this.cancel_reg_btn.Name = "cancel_reg_btn";
            this.cancel_reg_btn.Size = new System.Drawing.Size(71, 29);
            this.cancel_reg_btn.TabIndex = 35;
            this.cancel_reg_btn.Text = "Tühista";
            this.cancel_reg_btn.UseVisualStyleBackColor = false;
            this.cancel_reg_btn.Click += new System.EventHandler(this.cancel_reg_btn_Click);
            // 
            // EyeBox
            // 
            this.EyeBox.AutoSize = true;
            this.EyeBox.Location = new System.Drawing.Point(530, 242);
            this.EyeBox.Name = "EyeBox";
            this.EyeBox.Size = new System.Drawing.Size(15, 14);
            this.EyeBox.TabIndex = 37;
            this.EyeBox.UseVisualStyleBackColor = true;
            this.EyeBox.CheckedChanged += new System.EventHandler(this.EyeBox_CheckedChanged);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(247, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 23);
            this.label5.TabIndex = 38;
            this.label5.Text = "Salasõna";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.EyeBox);
            this.Controls.Add(this.cancel_reg_btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.reg_btn);
            this.Controls.Add(this.email_txt);
            this.Controls.Add(this.email_box);
            this.Controls.Add(this.rep_pass_text);
            this.Controls.Add(this.pass_box);
            this.Controls.Add(this.nimi_box);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "Register";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nimi_box;
        private System.Windows.Forms.TextBox pass_box;
        private System.Windows.Forms.TextBox rep_pass_text;
        private System.Windows.Forms.TextBox email_box;
        private System.Windows.Forms.Label email_txt;
        private System.Windows.Forms.Button reg_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cancel_reg_btn;
        private System.Windows.Forms.CheckBox EyeBox;
        private System.Windows.Forms.Label label5;
    }
}