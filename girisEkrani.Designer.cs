namespace nesne1._1
{
    partial class girisEkrani
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
            this.musteri_btn = new System.Windows.Forms.Button();
            this.personel_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.giris_baslik_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // musteri_btn
            // 
            this.musteri_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.musteri_btn.Location = new System.Drawing.Point(145, 162);
            this.musteri_btn.Name = "musteri_btn";
            this.musteri_btn.Size = new System.Drawing.Size(149, 74);
            this.musteri_btn.TabIndex = 1;
            this.musteri_btn.Text = "MÜŞTERİ";
            this.musteri_btn.UseVisualStyleBackColor = false;
            this.musteri_btn.Click += new System.EventHandler(this.musteri_btn_Click);
            // 
            // personel_btn
            // 
            this.personel_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.personel_btn.Location = new System.Drawing.Point(387, 162);
            this.personel_btn.Name = "personel_btn";
            this.personel_btn.Size = new System.Drawing.Size(149, 74);
            this.personel_btn.TabIndex = 2;
            this.personel_btn.Text = "PERSONEL";
            this.personel_btn.UseVisualStyleBackColor = false;
            this.personel_btn.Click += new System.EventHandler(this.personel_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(239, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 0;
            // 
            // giris_baslik_lbl
            // 
            this.giris_baslik_lbl.AutoSize = true;
            this.giris_baslik_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.giris_baslik_lbl.Location = new System.Drawing.Point(139, 53);
            this.giris_baslik_lbl.Name = "giris_baslik_lbl";
            this.giris_baslik_lbl.Size = new System.Drawing.Size(397, 32);
            this.giris_baslik_lbl.TabIndex = 0;
            this.giris_baslik_lbl.Text = "Lütfen kullanıcı tipinizi seçiniz.";
            // 
            // girisEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(690, 357);
            this.Controls.Add(this.giris_baslik_lbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.personel_btn);
            this.Controls.Add(this.musteri_btn);
            this.Name = "girisEkrani";
            this.Text = "Giriş Ekranı";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button musteri_btn;
        private System.Windows.Forms.Button personel_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label giris_baslik_lbl;
    }
}