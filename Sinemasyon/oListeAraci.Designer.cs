namespace Sinemasyon
{
    partial class oListeAraci
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

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblAdi = new System.Windows.Forms.Label();
            this.ekle = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ekle)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAdi
            // 
            this.lblAdi.AutoSize = true;
            this.lblAdi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAdi.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdi.Location = new System.Drawing.Point(26, 3);
            this.lblAdi.Name = "lblAdi";
            this.lblAdi.Size = new System.Drawing.Size(48, 20);
            this.lblAdi.TabIndex = 1;
            this.lblAdi.Text = "label1";
            this.lblAdi.Click += new System.EventHandler(this.lblAdi_Click);
  //          this.lblAdi.MouseLeave += new System.EventHandler(this.lblAdi_MouseLeave);
 //           this.lblAdi.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblAdi_MouseMove);
            // 
            // ekle
            // 
            this.ekle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ekle.Image = global::Sinemasyon.Properties.Resources.addition;
            this.ekle.Location = new System.Drawing.Point(3, 3);
            this.ekle.Name = "ekle";
            this.ekle.Size = new System.Drawing.Size(17, 21);
            this.ekle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ekle.TabIndex = 0;
            this.ekle.TabStop = false;
 //           this.ekle.Click += new System.EventHandler(this.ekle_Click);
            // 
            // oListeAraci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblAdi);
            this.Controls.Add(this.ekle);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "oListeAraci";
            this.Size = new System.Drawing.Size(183, 24);
            ((System.ComponentModel.ISupportInitialize)(this.ekle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ekle;
        public System.Windows.Forms.Label lblAdi;
    }
}
