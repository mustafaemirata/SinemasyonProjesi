namespace Sinemasyon
{
    partial class FrmSalonKayit
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.kapat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.koltukNo = new System.Windows.Forms.MaskedTextBox();
            this.EKLE = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.salonAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.salonPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.panel1.Controls.Add(this.kapat);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(741, 45);
            this.panel1.TabIndex = 3;
            // 
            // kapat
            // 
            this.kapat.BackColor = System.Drawing.Color.Red;
            this.kapat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kapat.Dock = System.Windows.Forms.DockStyle.Right;
            this.kapat.FlatAppearance.BorderSize = 0;
            this.kapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kapat.ForeColor = System.Drawing.Color.White;
            this.kapat.Location = new System.Drawing.Point(701, 0);
            this.kapat.Name = "kapat";
            this.kapat.Size = new System.Drawing.Size(40, 45);
            this.kapat.TabIndex = 1;
            this.kapat.Text = "X";
            this.kapat.UseVisualStyleBackColor = false;
            this.kapat.Click += new System.EventHandler(this.kapat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Salon Kayıt";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.koltukNo);
            this.groupBox1.Controls.Add(this.EKLE);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.salonAd);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.groupBox1.Location = new System.Drawing.Point(165, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(402, 198);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // koltukNo
            // 
            this.koltukNo.Location = new System.Drawing.Point(116, 83);
            this.koltukNo.Mask = "00000";
            this.koltukNo.Name = "koltukNo";
            this.koltukNo.Size = new System.Drawing.Size(261, 34);
            this.koltukNo.TabIndex = 10;
            this.koltukNo.ValidatingType = typeof(int);
            // 
            // EKLE
            // 
            this.EKLE.BackColor = System.Drawing.Color.DimGray;
            this.EKLE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EKLE.FlatAppearance.BorderSize = 0;
            this.EKLE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EKLE.ForeColor = System.Drawing.Color.White;
            this.EKLE.Location = new System.Drawing.Point(58, 134);
            this.EKLE.Name = "EKLE";
            this.EKLE.Size = new System.Drawing.Size(281, 45);
            this.EKLE.TabIndex = 9;
            this.EKLE.Text = "EKLE";
            this.EKLE.UseVisualStyleBackColor = false;
            this.EKLE.Click += new System.EventHandler(this.btnResimEkle_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 89);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(71, 28);
            this.label3.TabIndex = 7;
            this.label3.Text = "Koltuk";
            // 
            // salonAd
            // 
            this.salonAd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.salonAd.Location = new System.Drawing.Point(116, 27);
            this.salonAd.Name = "salonAd";
            this.salonAd.Size = new System.Drawing.Size(261, 34);
            this.salonAd.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 33);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(108, 28);
            this.label2.TabIndex = 5;
            this.label2.Text = "SALON AD";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.salonPanel);
            this.groupBox2.Location = new System.Drawing.Point(18, 276);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(711, 467);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // salonPanel
            // 
            this.salonPanel.AutoScroll = true;
            this.salonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.salonPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(150)));
            this.salonPanel.Location = new System.Drawing.Point(3, 34);
            this.salonPanel.Name = "salonPanel";
            this.salonPanel.Size = new System.Drawing.Size(705, 430);
            this.salonPanel.TabIndex = 0;
            // 
            // FrmSalonKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(741, 755);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(550, 55);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "FrmSalonKayit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FrmSalonKayit";
            this.Load += new System.EventHandler(this.FrmSalonKayit_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button kapat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox salonAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button EKLE;
        private System.Windows.Forms.MaskedTextBox koltukNo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.FlowLayoutPanel salonPanel;
    }
}