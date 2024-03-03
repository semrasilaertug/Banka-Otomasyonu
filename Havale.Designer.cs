namespace nesne1._1
{
    partial class Havale
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
            this.label1 = new System.Windows.Forms.Label();
            this.havale_btn = new System.Windows.Forms.Button();
            this.mtxtBox_havaleMiktari = new System.Windows.Forms.MaskedTextBox();
            this.gonderilecek_tutar_lbl = new System.Windows.Forms.Label();
            this.hesap_no2_lbl = new System.Windows.Forms.Label();
            this.hesap_no1_lbl = new System.Windows.Forms.Label();
            this.gonderilenHesap_textBox = new System.Windows.Forms.TextBox();
            this.guncel_bakiye_textBox = new System.Windows.Forms.TextBox();
            this.txtBox_gonderenHesapNo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(72, 320);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Güncel Bakiyeniz :";
            // 
            // havale_btn
            // 
            this.havale_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.havale_btn.Location = new System.Drawing.Point(580, 274);
            this.havale_btn.Name = "havale_btn";
            this.havale_btn.Size = new System.Drawing.Size(114, 38);
            this.havale_btn.TabIndex = 4;
            this.havale_btn.Text = "HAVALE YAP";
            this.havale_btn.UseVisualStyleBackColor = false;
            this.havale_btn.Click += new System.EventHandler(this.havale_btn_Click);
            // 
            // mtxtBox_havaleMiktari
            // 
            this.mtxtBox_havaleMiktari.Location = new System.Drawing.Point(495, 205);
            this.mtxtBox_havaleMiktari.Mask = "000";
            this.mtxtBox_havaleMiktari.Name = "mtxtBox_havaleMiktari";
            this.mtxtBox_havaleMiktari.Size = new System.Drawing.Size(199, 22);
            this.mtxtBox_havaleMiktari.TabIndex = 3;
            this.mtxtBox_havaleMiktari.ValidatingType = typeof(int);
            // 
            // gonderilecek_tutar_lbl
            // 
            this.gonderilecek_tutar_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gonderilecek_tutar_lbl.Location = new System.Drawing.Point(72, 201);
            this.gonderilecek_tutar_lbl.Name = "gonderilecek_tutar_lbl";
            this.gonderilecek_tutar_lbl.Size = new System.Drawing.Size(318, 30);
            this.gonderilecek_tutar_lbl.TabIndex = 0;
            this.gonderilecek_tutar_lbl.Text = "Havale yapılacak tutarı girin :";
            // 
            // hesap_no2_lbl
            // 
            this.hesap_no2_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hesap_no2_lbl.Location = new System.Drawing.Point(72, 127);
            this.hesap_no2_lbl.Name = "hesap_no2_lbl";
            this.hesap_no2_lbl.Size = new System.Drawing.Size(423, 30);
            this.hesap_no2_lbl.TabIndex = 0;
            this.hesap_no2_lbl.Text = "Havale yapacağınız hesap numarasını yazınız :";
            // 
            // hesap_no1_lbl
            // 
            this.hesap_no1_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hesap_no1_lbl.Location = new System.Drawing.Point(72, 59);
            this.hesap_no1_lbl.Name = "hesap_no1_lbl";
            this.hesap_no1_lbl.Size = new System.Drawing.Size(417, 30);
            this.hesap_no1_lbl.TabIndex = 0;
            this.hesap_no1_lbl.Text = "Hesap numaranızı giriniz :";
            // 
            // gonderilenHesap_textBox
            // 
            this.gonderilenHesap_textBox.Location = new System.Drawing.Point(495, 134);
            this.gonderilenHesap_textBox.Name = "gonderilenHesap_textBox";
            this.gonderilenHesap_textBox.Size = new System.Drawing.Size(199, 22);
            this.gonderilenHesap_textBox.TabIndex = 2;
            // 
            // guncel_bakiye_textBox
            // 
            this.guncel_bakiye_textBox.Enabled = false;
            this.guncel_bakiye_textBox.Location = new System.Drawing.Point(251, 324);
            this.guncel_bakiye_textBox.Name = "guncel_bakiye_textBox";
            this.guncel_bakiye_textBox.Size = new System.Drawing.Size(100, 22);
            this.guncel_bakiye_textBox.TabIndex = 0;
            // 
            // txtBox_gonderenHesapNo
            // 
            this.txtBox_gonderenHesapNo.Location = new System.Drawing.Point(495, 63);
            this.txtBox_gonderenHesapNo.Name = "txtBox_gonderenHesapNo";
            this.txtBox_gonderenHesapNo.Size = new System.Drawing.Size(198, 22);
            this.txtBox_gonderenHesapNo.TabIndex = 1;
            // 
            // Havale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBox_gonderenHesapNo);
            this.Controls.Add(this.guncel_bakiye_textBox);
            this.Controls.Add(this.gonderilenHesap_textBox);
            this.Controls.Add(this.hesap_no1_lbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.havale_btn);
            this.Controls.Add(this.mtxtBox_havaleMiktari);
            this.Controls.Add(this.gonderilecek_tutar_lbl);
            this.Controls.Add(this.hesap_no2_lbl);
            this.Name = "Havale";
            this.Text = "Havale";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button havale_btn;
        private System.Windows.Forms.MaskedTextBox mtxtBox_havaleMiktari;
        private System.Windows.Forms.Label gonderilecek_tutar_lbl;
        private System.Windows.Forms.Label hesap_no2_lbl;
        private System.Windows.Forms.Label hesap_no1_lbl;
        private System.Windows.Forms.TextBox gonderilenHesap_textBox;
        private System.Windows.Forms.TextBox guncel_bakiye_textBox;
        private System.Windows.Forms.TextBox txtBox_gonderenHesapNo;
    }
}