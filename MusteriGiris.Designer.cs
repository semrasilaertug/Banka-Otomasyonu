namespace nesne1._1
{
    partial class MusteriGiris
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
            this.musteri_no_lbl = new System.Windows.Forms.Label();
            this.musteri_giris_ekrani_lbl = new System.Windows.Forms.Label();
            this.musteri_sifre_lbl = new System.Windows.Forms.Label();
            this.musteri_no_textbox = new System.Windows.Forms.MaskedTextBox();
            this.musteri_sifre_textbox = new System.Windows.Forms.MaskedTextBox();
            this.musteri_giris_btn = new System.Windows.Forms.Button();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.SuspendLayout();
            // 
            // musteri_no_lbl
            // 
            this.musteri_no_lbl.AutoSize = true;
            this.musteri_no_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.musteri_no_lbl.Location = new System.Drawing.Point(78, 140);
            this.musteri_no_lbl.Name = "musteri_no_lbl";
            this.musteri_no_lbl.Size = new System.Drawing.Size(171, 22);
            this.musteri_no_lbl.TabIndex = 0;
            this.musteri_no_lbl.Text = "Müşteri Numarası:";
            // 
            // musteri_giris_ekrani_lbl
            // 
            this.musteri_giris_ekrani_lbl.AutoSize = true;
            this.musteri_giris_ekrani_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.musteri_giris_ekrani_lbl.Location = new System.Drawing.Point(153, 50);
            this.musteri_giris_ekrani_lbl.Name = "musteri_giris_ekrani_lbl";
            this.musteri_giris_ekrani_lbl.Size = new System.Drawing.Size(296, 36);
            this.musteri_giris_ekrani_lbl.TabIndex = 0;
            this.musteri_giris_ekrani_lbl.Text = "Müşteri Giriş Ekranı";
            // 
            // musteri_sifre_lbl
            // 
            this.musteri_sifre_lbl.AutoSize = true;
            this.musteri_sifre_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.musteri_sifre_lbl.Location = new System.Drawing.Point(78, 190);
            this.musteri_sifre_lbl.Name = "musteri_sifre_lbl";
            this.musteri_sifre_lbl.Size = new System.Drawing.Size(58, 22);
            this.musteri_sifre_lbl.TabIndex = 0;
            this.musteri_sifre_lbl.Text = "Şifre:";
            // 
            // musteri_no_textbox
            // 
            this.musteri_no_textbox.Location = new System.Drawing.Point(292, 142);
            this.musteri_no_textbox.Name = "musteri_no_textbox";
            this.musteri_no_textbox.Size = new System.Drawing.Size(157, 22);
            this.musteri_no_textbox.TabIndex = 1;
            // 
            // musteri_sifre_textbox
            // 
            this.musteri_sifre_textbox.Location = new System.Drawing.Point(292, 190);
            this.musteri_sifre_textbox.Name = "musteri_sifre_textbox";
            this.musteri_sifre_textbox.Size = new System.Drawing.Size(157, 22);
            this.musteri_sifre_textbox.TabIndex = 2;
            // 
            // musteri_giris_btn
            // 
            this.musteri_giris_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.musteri_giris_btn.Location = new System.Drawing.Point(303, 253);
            this.musteri_giris_btn.Name = "musteri_giris_btn";
            this.musteri_giris_btn.Size = new System.Drawing.Size(134, 49);
            this.musteri_giris_btn.TabIndex = 3;
            this.musteri_giris_btn.Text = "GİRİŞ YAP";
            this.musteri_giris_btn.UseVisualStyleBackColor = false;
            this.musteri_giris_btn.Click += new System.EventHandler(this.musteri_giris_btn_Click);
            // 
            // MusteriGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(607, 383);
            this.Controls.Add(this.musteri_giris_btn);
            this.Controls.Add(this.musteri_sifre_textbox);
            this.Controls.Add(this.musteri_no_textbox);
            this.Controls.Add(this.musteri_sifre_lbl);
            this.Controls.Add(this.musteri_giris_ekrani_lbl);
            this.Controls.Add(this.musteri_no_lbl);
            this.Name = "MusteriGiris";
            this.Text = "Müşteri Giriş Ekranı";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label musteri_no_lbl;
        private System.Windows.Forms.Label musteri_giris_ekrani_lbl;
        private System.Windows.Forms.Label musteri_sifre_lbl;
        private System.Windows.Forms.MaskedTextBox musteri_sifre_textbox;
        private System.Windows.Forms.Button musteri_giris_btn;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        public System.Windows.Forms.MaskedTextBox musteri_no_textbox;
    }
}