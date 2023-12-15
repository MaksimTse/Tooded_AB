namespace Tooded_AB
{
    partial class Login
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
            this.login_btn = new System.Windows.Forms.Button();
            this.create_user_btn = new System.Windows.Forms.Button();
            this.Nimi_box = new System.Windows.Forms.TextBox();
            this.Pass_box = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.forgot_pass_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // login_btn
            // 
            this.login_btn.BackColor = System.Drawing.Color.MediumAquamarine;
            this.login_btn.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.login_btn.Location = new System.Drawing.Point(270, 250);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(267, 47);
            this.login_btn.TabIndex = 0;
            this.login_btn.Text = "Logi sisse";
            this.login_btn.UseVisualStyleBackColor = false;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // create_user_btn
            // 
            this.create_user_btn.BackColor = System.Drawing.Color.LightSeaGreen;
            this.create_user_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.create_user_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.create_user_btn.Location = new System.Drawing.Point(446, 324);
            this.create_user_btn.Name = "create_user_btn";
            this.create_user_btn.Size = new System.Drawing.Size(91, 47);
            this.create_user_btn.TabIndex = 2;
            this.create_user_btn.Text = "Loo uus konto";
            this.create_user_btn.UseVisualStyleBackColor = false;
            // 
            // Nimi_box
            // 
            this.Nimi_box.Location = new System.Drawing.Point(270, 130);
            this.Nimi_box.Name = "Nimi_box";
            this.Nimi_box.Size = new System.Drawing.Size(267, 20);
            this.Nimi_box.TabIndex = 3;
            // 
            // Pass_box
            // 
            this.Pass_box.Location = new System.Drawing.Point(270, 197);
            this.Pass_box.Name = "Pass_box";
            this.Pass_box.PasswordChar = '*';
            this.Pass_box.ShortcutsEnabled = false;
            this.Pass_box.Size = new System.Drawing.Size(267, 20);
            this.Pass_box.TabIndex = 4;
            this.Pass_box.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(280, 335);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 23);
            this.label5.TabIndex = 22;
            this.label5.Text = "Teil ei ole kontot?";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(266, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 23);
            this.label1.TabIndex = 23;
            this.label1.Text = "Salasõna";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(266, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 23);
            this.label2.TabIndex = 24;
            this.label2.Text = "Kasutaja nimi";
            // 
            // forgot_pass_btn
            // 
            this.forgot_pass_btn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.forgot_pass_btn.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgot_pass_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.forgot_pass_btn.Location = new System.Drawing.Point(378, 168);
            this.forgot_pass_btn.Name = "forgot_pass_btn";
            this.forgot_pass_btn.Size = new System.Drawing.Size(159, 23);
            this.forgot_pass_btn.TabIndex = 25;
            this.forgot_pass_btn.Text = "Unustanud salasõna?";
            this.forgot_pass_btn.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(349, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 35);
            this.label3.TabIndex = 26;
            this.label3.Text = "Login";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.forgot_pass_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Pass_box);
            this.Controls.Add(this.Nimi_box);
            this.Controls.Add(this.create_user_btn);
            this.Controls.Add(this.login_btn);
            this.Name = "Login";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.Button create_user_btn;
        private System.Windows.Forms.TextBox Nimi_box;
        private System.Windows.Forms.TextBox Pass_box;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button forgot_pass_btn;
        private System.Windows.Forms.Label label3;
    }
}