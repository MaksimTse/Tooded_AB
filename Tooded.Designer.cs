namespace Tooded_AB
{
    partial class Tooded
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
            this.lisa_box = new System.Windows.Forms.ListBox();
            this.eemalda_box = new System.Windows.Forms.ListBox();
            this.add_item_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.toode_pic = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.reklaam_pic = new System.Windows.Forms.PictureBox();
            this.kassa_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.toode_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reklaam_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // lisa_box
            // 
            this.lisa_box.FormattingEnabled = true;
            this.lisa_box.Location = new System.Drawing.Point(421, 84);
            this.lisa_box.Name = "lisa_box";
            this.lisa_box.Size = new System.Drawing.Size(210, 212);
            this.lisa_box.TabIndex = 0;
            this.lisa_box.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // eemalda_box
            // 
            this.eemalda_box.FormattingEnabled = true;
            this.eemalda_box.Location = new System.Drawing.Point(421, 392);
            this.eemalda_box.Name = "eemalda_box";
            this.eemalda_box.Size = new System.Drawing.Size(210, 212);
            this.eemalda_box.TabIndex = 1;
            // 
            // add_item_btn
            // 
            this.add_item_btn.BackColor = System.Drawing.Color.PaleGreen;
            this.add_item_btn.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_item_btn.Location = new System.Drawing.Point(461, 302);
            this.add_item_btn.Name = "add_item_btn";
            this.add_item_btn.Size = new System.Drawing.Size(135, 39);
            this.add_item_btn.TabIndex = 2;
            this.add_item_btn.Text = "Lisa";
            this.add_item_btn.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(461, 347);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 39);
            this.button1.TabIndex = 3;
            this.button1.Text = "Eemalda";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // toode_pic
            // 
            this.toode_pic.Location = new System.Drawing.Point(56, 173);
            this.toode_pic.Name = "toode_pic";
            this.toode_pic.Size = new System.Drawing.Size(286, 284);
            this.toode_pic.TabIndex = 4;
            this.toode_pic.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(421, 57);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(210, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // reklaam_pic
            // 
            this.reklaam_pic.Location = new System.Drawing.Point(784, 31);
            this.reklaam_pic.Name = "reklaam_pic";
            this.reklaam_pic.Size = new System.Drawing.Size(181, 573);
            this.reklaam_pic.TabIndex = 6;
            this.reklaam_pic.TabStop = false;
            // 
            // kassa_btn
            // 
            this.kassa_btn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.kassa_btn.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kassa_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.kassa_btn.Location = new System.Drawing.Point(65, 523);
            this.kassa_btn.Name = "kassa_btn";
            this.kassa_btn.Size = new System.Drawing.Size(266, 59);
            this.kassa_btn.TabIndex = 7;
            this.kassa_btn.Text = "liigu kassasse";
            this.kassa_btn.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(484, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 35);
            this.label1.TabIndex = 8;
            this.label1.Text = "Pood";
            // 
            // Tooded
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 624);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kassa_btn);
            this.Controls.Add(this.reklaam_pic);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.toode_pic);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.add_item_btn);
            this.Controls.Add(this.eemalda_box);
            this.Controls.Add(this.lisa_box);
            this.Name = "Tooded";
            this.Text = "Tooded";
            ((System.ComponentModel.ISupportInitialize)(this.toode_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reklaam_pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lisa_box;
        private System.Windows.Forms.ListBox eemalda_box;
        private System.Windows.Forms.Button add_item_btn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox toode_pic;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox reklaam_pic;
        private System.Windows.Forms.Button kassa_btn;
        private System.Windows.Forms.Label label1;
    }
}