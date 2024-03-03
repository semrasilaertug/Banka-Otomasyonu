namespace nesne1._1
{
    partial class ParaYatir
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
            this.para_yatir_btn = new System.Windows.Forms.Button();
            this.yatirilacak_tutar_lbl = new System.Windows.Forms.Label();
            this.hesap_no_lbl = new System.Windows.Forms.Label();
            this.guncel_bakiye_textBox = new System.Windows.Forms.TextBox();
            this.txtBox_paraYatirilacakHesap = new System.Windows.Forms.TextBox();
            this.musteriNo_txtbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mtxtBox_yatirilacakTutar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(88, 332);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Güncel Bakiye :";
            // 
            // para_yatir_btn
            // 
            this.para_yatir_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.para_yatir_btn.Location = new System.Drawing.Point(430, 262);
            this.para_yatir_btn.Name = "para_yatir_btn";
            this.para_yatir_btn.Size = new System.Drawing.Size(139, 52);
            this.para_yatir_btn.TabIndex = 4;
            this.para_yatir_btn.Text = "PARA YATIR";
            this.para_yatir_btn.UseVisualStyleBackColor = false;
            this.para_yatir_btn.Click += new System.EventHandler(this.para_yatir_btn_Click);
            // 
            // yatirilacak_tutar_lbl
            // 
            this.yatirilacak_tutar_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yatirilacak_tutar_lbl.Location = new System.Drawing.Point(88, 205);
            this.yatirilacak_tutar_lbl.Name = "yatirilacak_tutar_lbl";
            this.yatirilacak_tutar_lbl.Size = new System.Drawing.Size(238, 30);
            this.yatirilacak_tutar_lbl.TabIndex = 0;
            this.yatirilacak_tutar_lbl.Text = "Yatırılacak Tutarı Girin :";
            // 
            // hesap_no_lbl
            // 
            this.hesap_no_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hesap_no_lbl.Location = new System.Drawing.Point(88, 131);
            this.hesap_no_lbl.Name = "hesap_no_lbl";
            this.hesap_no_lbl.Size = new System.Drawing.Size(238, 30);
            this.hesap_no_lbl.TabIndex = 0;
            this.hesap_no_lbl.Text = "Hesap numarasını giriniz :";
            // 
            // guncel_bakiye_textBox
            // 
            this.guncel_bakiye_textBox.Enabled = false;
            this.guncel_bakiye_textBox.Location = new System.Drawing.Point(254, 336);
            this.guncel_bakiye_textBox.Name = "guncel_bakiye_textBox";
            this.guncel_bakiye_textBox.Size = new System.Drawing.Size(100, 22);
            this.guncel_bakiye_textBox.TabIndex = 0;
            // 
            // txtBox_paraYatirilacakHesap
            // 
            this.txtBox_paraYatirilacakHesap.Location = new System.Drawing.Point(370, 135);
            this.txtBox_paraYatirilacakHesap.Name = "txtBox_paraYatirilacakHesap";
            this.txtBox_paraYatirilacakHesap.Size = new System.Drawing.Size(199, 22);
            this.txtBox_paraYatirilacakHesap.TabIndex = 2;
            // 
            // musteriNo_txtbox
            // 
            this.musteriNo_txtbox.Location = new System.Drawing.Point(370, 74);
            this.musteriNo_txtbox.Name = "musteriNo_txtbox";
            this.musteriNo_txtbox.Size = new System.Drawing.Size(199, 22);
            this.musteriNo_txtbox.TabIndex = 1;
            this.musteriNo_txtbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(88, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 30);
            this.label2.TabIndex = 6;
            this.label2.Text = "Müşteri numaranızı giriniz :";
            // 
            // mtxtBox_yatirilacakTutar
            // 
            this.mtxtBox_yatirilacakTutar.Location = new System.Drawing.Point(370, 209);
            this.mtxtBox_yatirilacakTutar.Name = "mtxtBox_yatirilacakTutar";
            this.mtxtBox_yatirilacakTutar.Size = new System.Drawing.Size(199, 22);
            this.mtxtBox_yatirilacakTutar.TabIndex = 3;
            // 
            // ParaYatir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(710, 475);
            this.Controls.Add(this.mtxtBox_yatirilacakTutar);
            this.Controls.Add(this.musteriNo_txtbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBox_paraYatirilacakHesap);
            this.Controls.Add(this.guncel_bakiye_textBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.para_yatir_btn);
            this.Controls.Add(this.yatirilacak_tutar_lbl);
            this.Controls.Add(this.hesap_no_lbl);
            this.Name = "ParaYatir";
            this.Text = "Para Yatır";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button para_yatir_btn;
        private System.Windows.Forms.Label yatirilacak_tutar_lbl;
        private System.Windows.Forms.Label hesap_no_lbl;
        private System.Windows.Forms.TextBox guncel_bakiye_textBox;
        private System.Windows.Forms.TextBox txtBox_paraYatirilacakHesap;
        private System.Windows.Forms.TextBox musteriNo_txtbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox mtxtBox_yatirilacakTutar;
    }
}