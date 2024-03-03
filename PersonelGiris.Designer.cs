namespace nesne1._1
{
    partial class PersonelGiris
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
            this.personel_giris_btn = new System.Windows.Forms.Button();
            this.personel_sifre_textbox = new System.Windows.Forms.MaskedTextBox();
            this.personel_no_textbox = new System.Windows.Forms.MaskedTextBox();
            this.personel_sifre_lbl = new System.Windows.Forms.Label();
            this.personel_giris_ekrani_lbl = new System.Windows.Forms.Label();
            this.personel_ad_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // personel_giris_btn
            // 
            this.personel_giris_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.personel_giris_btn.Location = new System.Drawing.Point(305, 257);
            this.personel_giris_btn.Name = "personel_giris_btn";
            this.personel_giris_btn.Size = new System.Drawing.Size(134, 49);
            this.personel_giris_btn.TabIndex = 3;
            this.personel_giris_btn.Text = "GİRİŞ YAP";
            this.personel_giris_btn.UseVisualStyleBackColor = false;
            this.personel_giris_btn.Click += new System.EventHandler(this.personel_giris_btn_Click);
            // 
            // personel_sifre_textbox
            // 
            this.personel_sifre_textbox.Location = new System.Drawing.Point(294, 194);
            this.personel_sifre_textbox.Name = "personel_sifre_textbox";
            this.personel_sifre_textbox.Size = new System.Drawing.Size(157, 22);
            this.personel_sifre_textbox.TabIndex = 2;
            // 
            // personel_no_textbox
            // 
            this.personel_no_textbox.Location = new System.Drawing.Point(294, 146);
            this.personel_no_textbox.Name = "personel_no_textbox";
            this.personel_no_textbox.Size = new System.Drawing.Size(157, 22);
            this.personel_no_textbox.TabIndex = 1;
            // 
            // personel_sifre_lbl
            // 
            this.personel_sifre_lbl.AutoSize = true;
            this.personel_sifre_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.personel_sifre_lbl.Location = new System.Drawing.Point(80, 194);
            this.personel_sifre_lbl.Name = "personel_sifre_lbl";
            this.personel_sifre_lbl.Size = new System.Drawing.Size(58, 22);
            this.personel_sifre_lbl.TabIndex = 0;
            this.personel_sifre_lbl.Text = "Şifre:";
            // 
            // personel_giris_ekrani_lbl
            // 
            this.personel_giris_ekrani_lbl.AutoSize = true;
            this.personel_giris_ekrani_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.personel_giris_ekrani_lbl.Location = new System.Drawing.Point(155, 54);
            this.personel_giris_ekrani_lbl.Name = "personel_giris_ekrani_lbl";
            this.personel_giris_ekrani_lbl.Size = new System.Drawing.Size(317, 36);
            this.personel_giris_ekrani_lbl.TabIndex = 0;
            this.personel_giris_ekrani_lbl.Text = "Personel Giriş Ekranı";
            // 
            // personel_ad_lbl
            // 
            this.personel_ad_lbl.AutoSize = true;
            this.personel_ad_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.personel_ad_lbl.Location = new System.Drawing.Point(80, 144);
            this.personel_ad_lbl.Name = "personel_ad_lbl";
            this.personel_ad_lbl.Size = new System.Drawing.Size(130, 22);
            this.personel_ad_lbl.TabIndex = 0;
            this.personel_ad_lbl.Text = "Personel Adı:";
            // 
            // PersonelGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(607, 383);
            this.Controls.Add(this.personel_giris_btn);
            this.Controls.Add(this.personel_sifre_textbox);
            this.Controls.Add(this.personel_no_textbox);
            this.Controls.Add(this.personel_sifre_lbl);
            this.Controls.Add(this.personel_giris_ekrani_lbl);
            this.Controls.Add(this.personel_ad_lbl);
            this.Name = "PersonelGiris";
            this.Text = "Personel Giriş";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button personel_giris_btn;
        private System.Windows.Forms.MaskedTextBox personel_sifre_textbox;
        private System.Windows.Forms.MaskedTextBox personel_no_textbox;
        private System.Windows.Forms.Label personel_sifre_lbl;
        private System.Windows.Forms.Label personel_giris_ekrani_lbl;
        private System.Windows.Forms.Label personel_ad_lbl;
    }
}