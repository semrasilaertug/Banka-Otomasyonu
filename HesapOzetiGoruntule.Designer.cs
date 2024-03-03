namespace nesne1._1
{
    partial class HesapOzetiGoruntule
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
            this.baslangic_dateTime = new System.Windows.Forms.DateTimePicker();
            this.bitis_dateTime = new System.Windows.Forms.DateTimePicker();
            this.baslangic_lbl = new System.Windows.Forms.Label();
            this.bitis_lbl = new System.Windows.Forms.Label();
            this.hesap_ozeti_panel = new System.Windows.Forms.Panel();
            this.dGridView_hesapOzeti = new System.Windows.Forms.DataGridView();
            this.hesap_ozet_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBox_HesapOzeti = new System.Windows.Forms.TextBox();
            this.hesap_ozeti_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridView_hesapOzeti)).BeginInit();
            this.SuspendLayout();
            // 
            // baslangic_dateTime
            // 
            this.baslangic_dateTime.Location = new System.Drawing.Point(120, 144);
            this.baslangic_dateTime.Name = "baslangic_dateTime";
            this.baslangic_dateTime.Size = new System.Drawing.Size(201, 22);
            this.baslangic_dateTime.TabIndex = 2;
            // 
            // bitis_dateTime
            // 
            this.bitis_dateTime.Location = new System.Drawing.Point(483, 144);
            this.bitis_dateTime.Name = "bitis_dateTime";
            this.bitis_dateTime.Size = new System.Drawing.Size(200, 22);
            this.bitis_dateTime.TabIndex = 3;
            // 
            // baslangic_lbl
            // 
            this.baslangic_lbl.AutoSize = true;
            this.baslangic_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.baslangic_lbl.Location = new System.Drawing.Point(36, 108);
            this.baslangic_lbl.Name = "baslangic_lbl";
            this.baslangic_lbl.Size = new System.Drawing.Size(130, 20);
            this.baslangic_lbl.TabIndex = 0;
            this.baslangic_lbl.Text = "Başlangıç Tarihi";
            // 
            // bitis_lbl
            // 
            this.bitis_lbl.AutoSize = true;
            this.bitis_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bitis_lbl.Location = new System.Drawing.Point(433, 108);
            this.bitis_lbl.Name = "bitis_lbl";
            this.bitis_lbl.Size = new System.Drawing.Size(90, 20);
            this.bitis_lbl.TabIndex = 0;
            this.bitis_lbl.Text = "Bitiş Tarihi";
            // 
            // hesap_ozeti_panel
            // 
            this.hesap_ozeti_panel.Controls.Add(this.dGridView_hesapOzeti);
            this.hesap_ozeti_panel.Location = new System.Drawing.Point(40, 241);
            this.hesap_ozeti_panel.Name = "hesap_ozeti_panel";
            this.hesap_ozeti_panel.Size = new System.Drawing.Size(721, 264);
            this.hesap_ozeti_panel.TabIndex = 5;
            // 
            // dGridView_hesapOzeti
            // 
            this.dGridView_hesapOzeti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridView_hesapOzeti.Location = new System.Drawing.Point(41, 35);
            this.dGridView_hesapOzeti.Name = "dGridView_hesapOzeti";
            this.dGridView_hesapOzeti.RowHeadersWidth = 51;
            this.dGridView_hesapOzeti.RowTemplate.Height = 24;
            this.dGridView_hesapOzeti.Size = new System.Drawing.Size(640, 197);
            this.dGridView_hesapOzeti.TabIndex = 0;
            // 
            // hesap_ozet_btn
            // 
            this.hesap_ozet_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.hesap_ozet_btn.Location = new System.Drawing.Point(335, 182);
            this.hesap_ozet_btn.Name = "hesap_ozet_btn";
            this.hesap_ozet_btn.Size = new System.Drawing.Size(134, 38);
            this.hesap_ozet_btn.TabIndex = 4;
            this.hesap_ozet_btn.Text = "GÖRÜNTÜLE";
            this.hesap_ozet_btn.UseVisualStyleBackColor = false;
            this.hesap_ozet_btn.Click += new System.EventHandler(this.hesap_ozet_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(164, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hesap numarasını yazınız :";
            // 
            // txtBox_HesapOzeti
            // 
            this.txtBox_HesapOzeti.Location = new System.Drawing.Point(410, 46);
            this.txtBox_HesapOzeti.Name = "txtBox_HesapOzeti";
            this.txtBox_HesapOzeti.Size = new System.Drawing.Size(186, 22);
            this.txtBox_HesapOzeti.TabIndex = 1;
            // 
            // HesapOzetiGoruntule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(808, 535);
            this.Controls.Add(this.txtBox_HesapOzeti);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hesap_ozet_btn);
            this.Controls.Add(this.hesap_ozeti_panel);
            this.Controls.Add(this.bitis_lbl);
            this.Controls.Add(this.baslangic_lbl);
            this.Controls.Add(this.bitis_dateTime);
            this.Controls.Add(this.baslangic_dateTime);
            this.Name = "HesapOzetiGoruntule";
            this.Text = "Hesap Özeti Görüntüle";
            this.hesap_ozeti_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGridView_hesapOzeti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker baslangic_dateTime;
        private System.Windows.Forms.DateTimePicker bitis_dateTime;
        private System.Windows.Forms.Label baslangic_lbl;
        private System.Windows.Forms.Label bitis_lbl;
        private System.Windows.Forms.Panel hesap_ozeti_panel;
        private System.Windows.Forms.Button hesap_ozet_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dGridView_hesapOzeti;
        private System.Windows.Forms.TextBox txtBox_HesapOzeti;
    }
}