namespace Sinemasyon
{
    partial class filmListesi
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
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.filmResmiBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.filmResim = new System.Windows.Forms.PictureBox();
            this.lblFilmAdi = new System.Windows.Forms.Label();
            this.LBLıd = new System.Windows.Forms.Label();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filmResim)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.LBLıd);
            this.groupBox9.Controls.Add(this.lblFilmAdi);
            this.groupBox9.Controls.Add(this.filmResmiBtn);
            this.groupBox9.Controls.Add(this.filmResim);
            this.groupBox9.Controls.Add(this.label6);
            this.groupBox9.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.groupBox9.Location = new System.Drawing.Point(14, 13);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(203, 276);
            this.groupBox9.TabIndex = 20;
            this.groupBox9.TabStop = false;
            // 
            // filmResmiBtn
            // 
            this.filmResmiBtn.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.filmResmiBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.filmResmiBtn.FlatAppearance.BorderSize = 0;
            this.filmResmiBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filmResmiBtn.ForeColor = System.Drawing.Color.White;
            this.filmResmiBtn.Location = new System.Drawing.Point(13, 229);
            this.filmResmiBtn.Name = "filmResmiBtn";
            this.filmResmiBtn.Size = new System.Drawing.Size(184, 33);
            this.filmResmiBtn.TabIndex = 5;
            this.filmResmiBtn.Text = "YÜKLE";
            this.filmResmiBtn.UseVisualStyleBackColor = false;
            this.filmResmiBtn.Click += new System.EventHandler(this.filmResmiBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 0);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(0, 28);
            this.label6.TabIndex = 6;
            // 
            // filmResim
            // 
            this.filmResim.Image = global::Sinemasyon.Properties.Resources.image;
            this.filmResim.Location = new System.Drawing.Point(56, 33);
            this.filmResim.Name = "filmResim";
            this.filmResim.Size = new System.Drawing.Size(121, 177);
            this.filmResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.filmResim.TabIndex = 7;
            this.filmResim.TabStop = false;
            // 
            // lblFilmAdi
            // 
            this.lblFilmAdi.AutoSize = true;
            this.lblFilmAdi.Location = new System.Drawing.Point(6, 0);
            this.lblFilmAdi.Name = "lblFilmAdi";
            this.lblFilmAdi.Size = new System.Drawing.Size(63, 28);
            this.lblFilmAdi.TabIndex = 8;
            this.lblFilmAdi.Text = "label1";
            // 
            // LBLıd
            // 
            this.LBLıd.AutoSize = true;
            this.LBLıd.Enabled = false;
            this.LBLıd.Location = new System.Drawing.Point(6, 198);
            this.LBLıd.Name = "LBLıd";
            this.LBLıd.Size = new System.Drawing.Size(63, 28);
            this.LBLıd.TabIndex = 9;
            this.LBLıd.Text = "label1";
            this.LBLıd.Visible = false;
            // 
            // filmListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox9);
            this.Name = "filmListesi";
            this.Size = new System.Drawing.Size(228, 301);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filmResim)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Button filmResmiBtn;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.PictureBox filmResim;
        public System.Windows.Forms.Label lblFilmAdi;
        public System.Windows.Forms.Label LBLıd;
    }
}
