namespace nesne1._1
{
    partial class HesapKapat
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
            this.kapatilacak_lbl = new System.Windows.Forms.Label();
            this.hesabi_kapat_btn = new System.Windows.Forms.Button();
            this.hesap_kapat_maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // kapatilacak_lbl
            // 
            this.kapatilacak_lbl.AutoSize = true;
            this.kapatilacak_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kapatilacak_lbl.Location = new System.Drawing.Point(28, 66);
            this.kapatilacak_lbl.Name = "kapatilacak_lbl";
            this.kapatilacak_lbl.Size = new System.Drawing.Size(191, 20);
            this.kapatilacak_lbl.TabIndex = 0;
            this.kapatilacak_lbl.Text = "Kapatılacak Hesabı Gir :";
            // 
            // hesabi_kapat_btn
            // 
            this.hesabi_kapat_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.hesabi_kapat_btn.Location = new System.Drawing.Point(270, 132);
            this.hesabi_kapat_btn.Name = "hesabi_kapat_btn";
            this.hesabi_kapat_btn.Size = new System.Drawing.Size(133, 44);
            this.hesabi_kapat_btn.TabIndex = 2;
            this.hesabi_kapat_btn.Text = "HESABI KAPAT";
            this.hesabi_kapat_btn.UseVisualStyleBackColor = false;
            this.hesabi_kapat_btn.Click += new System.EventHandler(this.hesabi_kapat_btn_Click);
            // 
            // hesap_kapat_maskedTextBox
            // 
            this.hesap_kapat_maskedTextBox.Location = new System.Drawing.Point(253, 64);
            this.hesap_kapat_maskedTextBox.Name = "hesap_kapat_maskedTextBox";
            this.hesap_kapat_maskedTextBox.Size = new System.Drawing.Size(150, 22);
            this.hesap_kapat_maskedTextBox.TabIndex = 1;
            // 
            // HesapKapat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(456, 237);
            this.Controls.Add(this.hesap_kapat_maskedTextBox);
            this.Controls.Add(this.hesabi_kapat_btn);
            this.Controls.Add(this.kapatilacak_lbl);
            this.Name = "HesapKapat";
            this.Text = "Hesap Kapatma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label kapatilacak_lbl;
        private System.Windows.Forms.Button hesabi_kapat_btn;
        private System.Windows.Forms.MaskedTextBox hesap_kapat_maskedTextBox;
    }
}