namespace nesne1._1
{
    partial class HesapSil
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
            this.hesapSil_btn = new System.Windows.Forms.Button();
            this.hesap_sil_maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.hesapNo_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hesapSil_btn
            // 
            this.hesapSil_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.hesapSil_btn.Location = new System.Drawing.Point(166, 132);
            this.hesapSil_btn.Name = "hesapSil_btn";
            this.hesapSil_btn.Size = new System.Drawing.Size(114, 38);
            this.hesapSil_btn.TabIndex = 2;
            this.hesapSil_btn.Text = "SİL";
            this.hesapSil_btn.UseVisualStyleBackColor = false;
            this.hesapSil_btn.Click += new System.EventHandler(this.hesapSil_btn_Click);
            // 
            // hesap_sil_maskedTextBox
            // 
            this.hesap_sil_maskedTextBox.Location = new System.Drawing.Point(225, 63);
            this.hesap_sil_maskedTextBox.Name = "hesap_sil_maskedTextBox";
            this.hesap_sil_maskedTextBox.Size = new System.Drawing.Size(150, 22);
            this.hesap_sil_maskedTextBox.TabIndex = 1;
            // 
            // hesapNo_lbl
            // 
            this.hesapNo_lbl.AutoSize = true;
            this.hesapNo_lbl.Location = new System.Drawing.Point(77, 66);
            this.hesapNo_lbl.Name = "hesapNo_lbl";
            this.hesapNo_lbl.Size = new System.Drawing.Size(115, 16);
            this.hesapNo_lbl.TabIndex = 0;
            this.hesapNo_lbl.Text = "Hesap Numarası :";
            // 
            // HesapSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(456, 237);
            this.Controls.Add(this.hesapSil_btn);
            this.Controls.Add(this.hesap_sil_maskedTextBox);
            this.Controls.Add(this.hesapNo_lbl);
            this.Name = "HesapSil";
            this.Text = "Hesap Sil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button hesapSil_btn;
        private System.Windows.Forms.MaskedTextBox hesap_sil_maskedTextBox;
        private System.Windows.Forms.Label hesapNo_lbl;
    }
}