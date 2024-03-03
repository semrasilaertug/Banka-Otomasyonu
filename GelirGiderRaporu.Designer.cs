namespace nesne1._1
{
    partial class GelirGiderRaporu
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
            this.components = new System.ComponentModel.Container();
            this.gelir_gider_lbl = new System.Windows.Forms.Label();
            this.gelir_gider_btn = new System.Windows.Forms.Button();
            this.gelir_gider_panel = new System.Windows.Forms.Panel();
            this.gelir_gider_dataGridView = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.gelir_gider_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gelir_gider_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // gelir_gider_lbl
            // 
            this.gelir_gider_lbl.AutoSize = true;
            this.gelir_gider_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gelir_gider_lbl.Location = new System.Drawing.Point(85, 65);
            this.gelir_gider_lbl.Name = "gelir_gider_lbl";
            this.gelir_gider_lbl.Size = new System.Drawing.Size(353, 29);
            this.gelir_gider_lbl.TabIndex = 0;
            this.gelir_gider_lbl.Text = "Gelir Gider Raporunu Görüntüle";
            // 
            // gelir_gider_btn
            // 
            this.gelir_gider_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gelir_gider_btn.Location = new System.Drawing.Point(489, 53);
            this.gelir_gider_btn.Name = "gelir_gider_btn";
            this.gelir_gider_btn.Size = new System.Drawing.Size(168, 60);
            this.gelir_gider_btn.TabIndex = 1;
            this.gelir_gider_btn.Text = "GÖRÜNTÜLE";
            this.gelir_gider_btn.UseVisualStyleBackColor = false;
            this.gelir_gider_btn.Click += new System.EventHandler(this.gelir_gider_btn_Click);
            // 
            // gelir_gider_panel
            // 
            this.gelir_gider_panel.Controls.Add(this.gelir_gider_dataGridView);
            this.gelir_gider_panel.Location = new System.Drawing.Point(50, 163);
            this.gelir_gider_panel.Name = "gelir_gider_panel";
            this.gelir_gider_panel.Size = new System.Drawing.Size(693, 285);
            this.gelir_gider_panel.TabIndex = 2;
            // 
            // gelir_gider_dataGridView
            // 
            this.gelir_gider_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gelir_gider_dataGridView.Location = new System.Drawing.Point(40, 39);
            this.gelir_gider_dataGridView.Name = "gelir_gider_dataGridView";
            this.gelir_gider_dataGridView.RowHeadersWidth = 51;
            this.gelir_gider_dataGridView.RowTemplate.Height = 24;
            this.gelir_gider_dataGridView.Size = new System.Drawing.Size(614, 213);
            this.gelir_gider_dataGridView.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // GelirGiderRaporu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 491);
            this.Controls.Add(this.gelir_gider_panel);
            this.Controls.Add(this.gelir_gider_btn);
            this.Controls.Add(this.gelir_gider_lbl);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "GelirGiderRaporu";
            this.Text = "Gelir Gider Raporu";
            this.gelir_gider_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gelir_gider_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label gelir_gider_lbl;
        private System.Windows.Forms.Button gelir_gider_btn;
        private System.Windows.Forms.Panel gelir_gider_panel;
        private System.Windows.Forms.DataGridView gelir_gider_dataGridView;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}