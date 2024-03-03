namespace nesne1._1
{
    partial class HesapEkle
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
            this.hesapEkle_btn = new System.Windows.Forms.Button();
            this.hesap_ekle_maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.musteriNo_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hesapEkle_btn
            // 
            this.hesapEkle_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.hesapEkle_btn.Location = new System.Drawing.Point(168, 134);
            this.hesapEkle_btn.Name = "hesapEkle_btn";
            this.hesapEkle_btn.Size = new System.Drawing.Size(114, 38);
            this.hesapEkle_btn.TabIndex = 2;
            this.hesapEkle_btn.Text = "EKLE";
            this.hesapEkle_btn.UseVisualStyleBackColor = false;
            this.hesapEkle_btn.Click += new System.EventHandler(this.hesapEkle_btn_Click);
            // 
            // hesap_ekle_maskedTextBox
            // 
            this.hesap_ekle_maskedTextBox.Location = new System.Drawing.Point(227, 65);
            this.hesap_ekle_maskedTextBox.Name = "hesap_ekle_maskedTextBox";
            this.hesap_ekle_maskedTextBox.Size = new System.Drawing.Size(150, 22);
            this.hesap_ekle_maskedTextBox.TabIndex = 1;
            // 
            // musteriNo_lbl
            // 
            this.musteriNo_lbl.AutoSize = true;
            this.musteriNo_lbl.Location = new System.Drawing.Point(79, 68);
            this.musteriNo_lbl.Name = "musteriNo_lbl";
            this.musteriNo_lbl.Size = new System.Drawing.Size(117, 16);
            this.musteriNo_lbl.TabIndex = 0;
            this.musteriNo_lbl.Text = "Müşteri Numarası :";
            // 
            // HesapEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(456, 237);
            this.Controls.Add(this.hesapEkle_btn);
            this.Controls.Add(this.hesap_ekle_maskedTextBox);
            this.Controls.Add(this.musteriNo_lbl);
            this.Name = "HesapEkle";
            this.Text = "Hesap Ekle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button hesapEkle_btn;
        private System.Windows.Forms.MaskedTextBox hesap_ekle_maskedTextBox;
        private System.Windows.Forms.Label musteriNo_lbl;
    }
}