namespace nesne1._1
{
    partial class musteriSil
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
            this.musteriNo_lbl = new System.Windows.Forms.Label();
            this.musteri_sil_maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.sil_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // musteriNo_lbl
            // 
            this.musteriNo_lbl.AutoSize = true;
            this.musteriNo_lbl.Location = new System.Drawing.Point(70, 72);
            this.musteriNo_lbl.Name = "musteriNo_lbl";
            this.musteriNo_lbl.Size = new System.Drawing.Size(117, 16);
            this.musteriNo_lbl.TabIndex = 0;
            this.musteriNo_lbl.Text = "Müşteri Numarası :";
            // 
            // musteri_sil_maskedTextBox
            // 
            this.musteri_sil_maskedTextBox.Location = new System.Drawing.Point(218, 69);
            this.musteri_sil_maskedTextBox.Name = "musteri_sil_maskedTextBox";
            this.musteri_sil_maskedTextBox.Size = new System.Drawing.Size(150, 22);
            this.musteri_sil_maskedTextBox.TabIndex = 1;
            // 
            // sil_btn
            // 
            this.sil_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.sil_btn.Location = new System.Drawing.Point(159, 138);
            this.sil_btn.Name = "sil_btn";
            this.sil_btn.Size = new System.Drawing.Size(114, 38);
            this.sil_btn.TabIndex = 2;
            this.sil_btn.Text = "SİL";
            this.sil_btn.UseVisualStyleBackColor = false;
            this.sil_btn.Click += new System.EventHandler(this.sil_btn_Click);
            // 
            // musteriSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(456, 237);
            this.Controls.Add(this.sil_btn);
            this.Controls.Add(this.musteri_sil_maskedTextBox);
            this.Controls.Add(this.musteriNo_lbl);
            this.Name = "musteriSil";
            this.Text = "Müşteri Sil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label musteriNo_lbl;
        private System.Windows.Forms.MaskedTextBox musteri_sil_maskedTextBox;
        private System.Windows.Forms.Button sil_btn;
    }
}