namespace nesne1._1
{
    partial class HesapListele
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
            this.hesap_listele_btn = new System.Windows.Forms.Button();
            this.hesap_listele_lbl = new System.Windows.Forms.Label();
            this.hesap_panel = new System.Windows.Forms.Panel();
            this.dgrid_hesapListele = new System.Windows.Forms.DataGridView();
            this.hesap_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_hesapListele)).BeginInit();
            this.SuspendLayout();
            // 
            // hesap_listele_btn
            // 
            this.hesap_listele_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.hesap_listele_btn.Location = new System.Drawing.Point(787, 54);
            this.hesap_listele_btn.Name = "hesap_listele_btn";
            this.hesap_listele_btn.Size = new System.Drawing.Size(133, 45);
            this.hesap_listele_btn.TabIndex = 1;
            this.hesap_listele_btn.Text = "LİSTELE";
            this.hesap_listele_btn.UseVisualStyleBackColor = false;
            this.hesap_listele_btn.Click += new System.EventHandler(this.hesap_listele_btn_Click);
            // 
            // hesap_listele_lbl
            // 
            this.hesap_listele_lbl.AutoSize = true;
            this.hesap_listele_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hesap_listele_lbl.Location = new System.Drawing.Point(216, 54);
            this.hesap_listele_lbl.Name = "hesap_listele_lbl";
            this.hesap_listele_lbl.Size = new System.Drawing.Size(331, 32);
            this.hesap_listele_lbl.TabIndex = 0;
            this.hesap_listele_lbl.Text = "Tüm Hesapları Görüntüle";
            // 
            // hesap_panel
            // 
            this.hesap_panel.Controls.Add(this.dgrid_hesapListele);
            this.hesap_panel.Location = new System.Drawing.Point(39, 161);
            this.hesap_panel.Name = "hesap_panel";
            this.hesap_panel.Size = new System.Drawing.Size(1038, 458);
            this.hesap_panel.TabIndex = 2;
            // 
            // dgrid_hesapListele
            // 
            this.dgrid_hesapListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_hesapListele.Location = new System.Drawing.Point(37, 38);
            this.dgrid_hesapListele.Name = "dgrid_hesapListele";
            this.dgrid_hesapListele.RowHeadersWidth = 51;
            this.dgrid_hesapListele.RowTemplate.Height = 24;
            this.dgrid_hesapListele.Size = new System.Drawing.Size(966, 383);
            this.dgrid_hesapListele.TabIndex = 0;
            // 
            // HesapListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1121, 651);
            this.Controls.Add(this.hesap_listele_btn);
            this.Controls.Add(this.hesap_listele_lbl);
            this.Controls.Add(this.hesap_panel);
            this.Name = "HesapListele";
            this.Text = "HesapListele";
            this.hesap_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_hesapListele)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button hesap_listele_btn;
        private System.Windows.Forms.Label hesap_listele_lbl;
        private System.Windows.Forms.Panel hesap_panel;
        private System.Windows.Forms.DataGridView dgrid_hesapListele;
    }
}