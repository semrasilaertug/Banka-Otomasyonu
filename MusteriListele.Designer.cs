namespace nesne1._1
{
    partial class MusteriListele
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
            this.musteri_panel = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.musteri_listele_lbl = new System.Windows.Forms.Label();
            this.musteri_listele_btn = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.musteri_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // musteri_panel
            // 
            this.musteri_panel.Controls.Add(this.dataGridView1);
            this.musteri_panel.Location = new System.Drawing.Point(40, 183);
            this.musteri_panel.Name = "musteri_panel";
            this.musteri_panel.Size = new System.Drawing.Size(1088, 442);
            this.musteri_panel.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(47, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(990, 361);
            this.dataGridView1.TabIndex = 0;
            // 
            // musteri_listele_lbl
            // 
            this.musteri_listele_lbl.AutoSize = true;
            this.musteri_listele_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.musteri_listele_lbl.Location = new System.Drawing.Point(183, 78);
            this.musteri_listele_lbl.Name = "musteri_listele_lbl";
            this.musteri_listele_lbl.Size = new System.Drawing.Size(342, 32);
            this.musteri_listele_lbl.TabIndex = 0;
            this.musteri_listele_lbl.Text = "Tüm Müşterileri Görüntüle";
            // 
            // musteri_listele_btn
            // 
            this.musteri_listele_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.musteri_listele_btn.Location = new System.Drawing.Point(861, 77);
            this.musteri_listele_btn.Name = "musteri_listele_btn";
            this.musteri_listele_btn.Size = new System.Drawing.Size(133, 45);
            this.musteri_listele_btn.TabIndex = 1;
            this.musteri_listele_btn.Text = "LİSTELE";
            this.musteri_listele_btn.UseVisualStyleBackColor = false;
            this.musteri_listele_btn.Click += new System.EventHandler(this.musteri_listele_btn_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // MusteriListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1179, 637);
            this.Controls.Add(this.musteri_listele_btn);
            this.Controls.Add(this.musteri_listele_lbl);
            this.Controls.Add(this.musteri_panel);
            this.Name = "MusteriListele";
            this.Text = "Müşteri Listele";
            this.musteri_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel musteri_panel;
        private System.Windows.Forms.Label musteri_listele_lbl;
        private System.Windows.Forms.Button musteri_listele_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}