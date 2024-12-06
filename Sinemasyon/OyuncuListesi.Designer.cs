namespace Sinemasyon
{
    partial class OyuncuListesi
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
            this.silmeIslemi = new System.Windows.Forms.Button();
            this.lblCinsiyet = new System.Windows.Forms.Label();
            this.pbCinsiyet = new System.Windows.Forms.PictureBox();
            this.DetayButon = new System.Windows.Forms.Button();
            this.imGE = new System.Windows.Forms.PictureBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbCinsiyet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imGE)).BeginInit();
            this.SuspendLayout();
            // 
            // silmeIslemi
            // 
            this.silmeIslemi.BackColor = System.Drawing.Color.Firebrick;
            this.silmeIslemi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.silmeIslemi.FlatAppearance.BorderSize = 0;
            this.silmeIslemi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.silmeIslemi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.silmeIslemi.ForeColor = System.Drawing.Color.White;
            this.silmeIslemi.Location = new System.Drawing.Point(317, 87);
            this.silmeIslemi.Name = "silmeIslemi";
            this.silmeIslemi.Size = new System.Drawing.Size(126, 33);
            this.silmeIslemi.TabIndex = 17;
            this.silmeIslemi.Text = "SİL";
            this.silmeIslemi.UseVisualStyleBackColor = false;
            this.silmeIslemi.Click += new System.EventHandler(this.silmeIslemi_Click);
            // 
            // lblCinsiyet
            // 
            this.lblCinsiyet.AutoSize = true;
            this.lblCinsiyet.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblCinsiyet.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCinsiyet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.lblCinsiyet.Location = new System.Drawing.Point(243, 56);
            this.lblCinsiyet.Name = "lblCinsiyet";
            this.lblCinsiyet.Size = new System.Drawing.Size(86, 35);
            this.lblCinsiyet.TabIndex = 16;
            this.lblCinsiyet.Text = "label1";
            this.lblCinsiyet.Visible = false;
            // 
            // pbCinsiyet
            // 
            this.pbCinsiyet.Image = global::Sinemasyon.Properties.Resources.male;
            this.pbCinsiyet.Location = new System.Drawing.Point(114, 97);
            this.pbCinsiyet.Name = "pbCinsiyet";
            this.pbCinsiyet.Size = new System.Drawing.Size(21, 23);
            this.pbCinsiyet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCinsiyet.TabIndex = 15;
            this.pbCinsiyet.TabStop = false;
            // 
            // DetayButon
            // 
            this.DetayButon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.DetayButon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DetayButon.FlatAppearance.BorderSize = 0;
            this.DetayButon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DetayButon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DetayButon.ForeColor = System.Drawing.Color.White;
            this.DetayButon.Location = new System.Drawing.Point(158, 87);
            this.DetayButon.Name = "DetayButon";
            this.DetayButon.Size = new System.Drawing.Size(126, 33);
            this.DetayButon.TabIndex = 14;
            this.DetayButon.Text = "DETAY";
            this.DetayButon.UseVisualStyleBackColor = false;
            this.DetayButon.Click += new System.EventHandler(this.DetayButon_Click);
            // 
            // imGE
            // 
            this.imGE.Image = global::Sinemasyon.Properties.Resources.onurtuna_120050343_341526400529697_3999366646277535484_n_819x1024;
            this.imGE.Location = new System.Drawing.Point(21, 56);
            this.imGE.Name = "imGE";
            this.imGE.Size = new System.Drawing.Size(70, 64);
            this.imGE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imGE.TabIndex = 13;
            this.imGE.TabStop = false;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblID.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.lblID.Location = new System.Drawing.Point(127, 56);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(86, 35);
            this.lblID.TabIndex = 12;
            this.lblID.Text = "label1";
            this.lblID.Visible = false;
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblAdSoyad.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdSoyad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.lblAdSoyad.Location = new System.Drawing.Point(229, 69);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(148, 35);
            this.lblAdSoyad.TabIndex = 11;
            this.lblAdSoyad.Text = "lblAdSoyad";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 129);
            this.panel1.TabIndex = 10;
            // 
            // OyuncuListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.silmeIslemi);
            this.Controls.Add(this.lblCinsiyet);
            this.Controls.Add(this.pbCinsiyet);
            this.Controls.Add(this.DetayButon);
            this.Controls.Add(this.imGE);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblAdSoyad);
            this.Controls.Add(this.panel1);
            this.Name = "OyuncuListesi";
            this.Size = new System.Drawing.Size(549, 129);
            ((System.ComponentModel.ISupportInitialize)(this.pbCinsiyet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imGE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button silmeIslemi;
        public System.Windows.Forms.Label lblCinsiyet;
        private System.Windows.Forms.PictureBox pbCinsiyet;
        private System.Windows.Forms.Button DetayButon;
        public System.Windows.Forms.PictureBox imGE;
        public System.Windows.Forms.Label lblID;
        public System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.Panel panel1;
    }
}
