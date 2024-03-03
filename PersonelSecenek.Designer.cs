namespace nesne1._1
{
    partial class PersonelSecenek
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.müşteriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.hesapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.hesapToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.hesapEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.hesapToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.gelirGiderRaporuGörüntüleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.çIKIŞYAPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.müşteriToolStripMenuItem,
            this.müşteriSilToolStripMenuItem,
            this.hesapEkleToolStripMenuItem,
            this.gelirGiderRaporuGörüntüleToolStripMenuItem,
            this.toolStripMenuItem1,
            this.çIKIŞYAPToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // müşteriToolStripMenuItem
            // 
            this.müşteriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.müşteriToolStripMenuItem1,
            this.hesapToolStripMenuItem});
            this.müşteriToolStripMenuItem.Name = "müşteriToolStripMenuItem";
            this.müşteriToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.müşteriToolStripMenuItem.Text = "EKLE";
            // 
            // müşteriToolStripMenuItem1
            // 
            this.müşteriToolStripMenuItem1.Name = "müşteriToolStripMenuItem1";
            this.müşteriToolStripMenuItem1.Size = new System.Drawing.Size(141, 26);
            this.müşteriToolStripMenuItem1.Text = "Müşteri";
            this.müşteriToolStripMenuItem1.Click += new System.EventHandler(this.müşteriToolStripMenuItem1_Click);
            // 
            // hesapToolStripMenuItem
            // 
            this.hesapToolStripMenuItem.Name = "hesapToolStripMenuItem";
            this.hesapToolStripMenuItem.Size = new System.Drawing.Size(141, 26);
            this.hesapToolStripMenuItem.Text = "Hesap";
            this.hesapToolStripMenuItem.Click += new System.EventHandler(this.hesapToolStripMenuItem_Click);
            // 
            // müşteriSilToolStripMenuItem
            // 
            this.müşteriSilToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.müşteriToolStripMenuItem2,
            this.hesapToolStripMenuItem1});
            this.müşteriSilToolStripMenuItem.Name = "müşteriSilToolStripMenuItem";
            this.müşteriSilToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.müşteriSilToolStripMenuItem.Text = "LİSTELE";
            // 
            // müşteriToolStripMenuItem2
            // 
            this.müşteriToolStripMenuItem2.Name = "müşteriToolStripMenuItem2";
            this.müşteriToolStripMenuItem2.Size = new System.Drawing.Size(141, 26);
            this.müşteriToolStripMenuItem2.Text = "Müşteri";
            this.müşteriToolStripMenuItem2.Click += new System.EventHandler(this.müşteriToolStripMenuItem2_Click);
            // 
            // hesapToolStripMenuItem1
            // 
            this.hesapToolStripMenuItem1.Name = "hesapToolStripMenuItem1";
            this.hesapToolStripMenuItem1.Size = new System.Drawing.Size(141, 26);
            this.hesapToolStripMenuItem1.Text = "Hesap";
            this.hesapToolStripMenuItem1.Click += new System.EventHandler(this.hesapToolStripMenuItem1_Click);
            // 
            // hesapEkleToolStripMenuItem
            // 
            this.hesapEkleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.müşteriToolStripMenuItem3,
            this.hesapToolStripMenuItem2});
            this.hesapEkleToolStripMenuItem.Name = "hesapEkleToolStripMenuItem";
            this.hesapEkleToolStripMenuItem.Size = new System.Drawing.Size(42, 24);
            this.hesapEkleToolStripMenuItem.Text = "SİL";
            // 
            // müşteriToolStripMenuItem3
            // 
            this.müşteriToolStripMenuItem3.Name = "müşteriToolStripMenuItem3";
            this.müşteriToolStripMenuItem3.Size = new System.Drawing.Size(141, 26);
            this.müşteriToolStripMenuItem3.Text = "Müşteri";
            this.müşteriToolStripMenuItem3.Click += new System.EventHandler(this.müşteriToolStripMenuItem3_Click);
            // 
            // hesapToolStripMenuItem2
            // 
            this.hesapToolStripMenuItem2.Name = "hesapToolStripMenuItem2";
            this.hesapToolStripMenuItem2.Size = new System.Drawing.Size(141, 26);
            this.hesapToolStripMenuItem2.Text = "Hesap";
            this.hesapToolStripMenuItem2.Click += new System.EventHandler(this.hesapToolStripMenuItem2_Click);
            // 
            // gelirGiderRaporuGörüntüleToolStripMenuItem
            // 
            this.gelirGiderRaporuGörüntüleToolStripMenuItem.Name = "gelirGiderRaporuGörüntüleToolStripMenuItem";
            this.gelirGiderRaporuGörüntüleToolStripMenuItem.Size = new System.Drawing.Size(258, 24);
            this.gelirGiderRaporuGörüntüleToolStripMenuItem.Text = "GELİR-GİDER RAPORU GÖRÜNTÜLE";
            this.gelirGiderRaporuGörüntüleToolStripMenuItem.Click += new System.EventHandler(this.gelirGiderRaporuGörüntüleToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(14, 24);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // çIKIŞYAPToolStripMenuItem
            // 
            this.çIKIŞYAPToolStripMenuItem.Name = "çIKIŞYAPToolStripMenuItem";
            this.çIKIŞYAPToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.çIKIŞYAPToolStripMenuItem.Text = "ÇIKIŞ YAP";
            this.çIKIŞYAPToolStripMenuItem.Click += new System.EventHandler(this.çIKIŞYAPToolStripMenuItem_Click);
            // 
            // PersonelSecenek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PersonelSecenek";
            this.Text = "Personel Ekranı";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem müşteriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşteriSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hesapEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gelirGiderRaporuGörüntüleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem müşteriToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem hesapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşteriToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem hesapToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem müşteriToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem hesapToolStripMenuItem2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem çIKIŞYAPToolStripMenuItem;
    }
}

