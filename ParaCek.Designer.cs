namespace nesne1._1
{
    partial class ParaCek
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
            this.hesap_no_lbl = new System.Windows.Forms.Label();
            this.cekilecek_tutar_lbl = new System.Windows.Forms.Label();
            this.para_cek_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.guncel_bakiye_textBox = new System.Windows.Forms.TextBox();
            this.txtBox_cekilecekHesapNo = new System.Windows.Forms.TextBox();
            this.cekilecek_textbox = new System.Windows.Forms.TextBox();
            this.musteriNo_txtbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hesap_no_lbl
            // 
            this.hesap_no_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hesap_no_lbl.Location = new System.Drawing.Point(53, 164);
            this.hesap_no_lbl.Name = "hesap_no_lbl";
            this.hesap_no_lbl.Size = new System.Drawing.Size(427, 30);
            this.hesap_no_lbl.TabIndex = 0;
            this.hesap_no_lbl.Text = "Para çekilecek hesabınızın numarasını girin:";
            // 
            // cekilecek_tutar_lbl
            // 
            this.cekilecek_tutar_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cekilecek_tutar_lbl.Location = new System.Drawing.Point(53, 238);
            this.cekilecek_tutar_lbl.Name = "cekilecek_tutar_lbl";
            this.cekilecek_tutar_lbl.Size = new System.Drawing.Size(238, 30);
            this.cekilecek_tutar_lbl.TabIndex = 0;
            this.cekilecek_tutar_lbl.Text = "Çekilecek tutarı girin :";
            // 
            // para_cek_btn
            // 
            this.para_cek_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.para_cek_btn.Location = new System.Drawing.Point(556, 335);
            this.para_cek_btn.Name = "para_cek_btn";
            this.para_cek_btn.Size = new System.Drawing.Size(160, 47);
            this.para_cek_btn.TabIndex = 4;
            this.para_cek_btn.Text = "PARA ÇEK";
            this.para_cek_btn.UseVisualStyleBackColor = false;
            this.para_cek_btn.Click += new System.EventHandler(this.para_cek_btn_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(53, 412);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Güncel Bakiye :";
            // 
            // guncel_bakiye_textBox
            // 
            this.guncel_bakiye_textBox.Enabled = false;
            this.guncel_bakiye_textBox.Location = new System.Drawing.Point(219, 416);
            this.guncel_bakiye_textBox.Name = "guncel_bakiye_textBox";
            this.guncel_bakiye_textBox.Size = new System.Drawing.Size(100, 22);
            this.guncel_bakiye_textBox.TabIndex = 0;
            // 
            // txtBox_cekilecekHesapNo
            // 
            this.txtBox_cekilecekHesapNo.Location = new System.Drawing.Point(516, 168);
            this.txtBox_cekilecekHesapNo.Name = "txtBox_cekilecekHesapNo";
            this.txtBox_cekilecekHesapNo.Size = new System.Drawing.Size(200, 22);
            this.txtBox_cekilecekHesapNo.TabIndex = 2;
            // 
            // cekilecek_textbox
            // 
            this.cekilecek_textbox.Location = new System.Drawing.Point(516, 242);
            this.cekilecek_textbox.Name = "cekilecek_textbox";
            this.cekilecek_textbox.Size = new System.Drawing.Size(200, 22);
            this.cekilecek_textbox.TabIndex = 3;
            // 
            // musteriNo_txtbox
            // 
            this.musteriNo_txtbox.Location = new System.Drawing.Point(516, 104);
            this.musteriNo_txtbox.Name = "musteriNo_txtbox";
            this.musteriNo_txtbox.Size = new System.Drawing.Size(199, 22);
            this.musteriNo_txtbox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(53, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "Müşteri numaranızı giriniz :";
            // 
            // ParaCek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 505);
            this.Controls.Add(this.musteriNo_txtbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cekilecek_textbox);
            this.Controls.Add(this.txtBox_cekilecekHesapNo);
            this.Controls.Add(this.guncel_bakiye_textBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.para_cek_btn);
            this.Controls.Add(this.cekilecek_tutar_lbl);
            this.Controls.Add(this.hesap_no_lbl);
            this.Name = "ParaCek";
            this.Text = "Para Çek";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label hesap_no_lbl;
        private System.Windows.Forms.Label cekilecek_tutar_lbl;
        private System.Windows.Forms.Button para_cek_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox guncel_bakiye_textBox;
        private System.Windows.Forms.TextBox txtBox_cekilecekHesapNo;
        private System.Windows.Forms.TextBox cekilecek_textbox;
        private System.Windows.Forms.TextBox musteriNo_txtbox;
        private System.Windows.Forms.Label label2;
    }
}