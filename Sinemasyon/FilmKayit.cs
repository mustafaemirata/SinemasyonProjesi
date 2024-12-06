using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Data.Sql;

namespace Sinemasyon
{
    public partial class FilmKayit : Form
    {
        public FilmKayit()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=EMIR\\SQLEXPRESS;Initial Catalog=DbSinemasyon;Integrated Security=True");
        public string resimYolu;

        private void FilmKayit_Load(object sender, EventArgs e)
        {
            yListeGetir();
            oListeGetir();
            bugunTarih();
        }

        void bugunTarih()
        {
            nGun.Value = DateTime.Today.Day;
            nAy.Value = DateTime.Today.Month;
            nYil.Value = DateTime.Today.Year;   

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void filmResmiBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Title = "RESİM SEÇME",
                Filter = "PNG|*.png|JPG|*.jpg|JPEG|*.jpeg|All Files|*.*",
                FilterIndex = 3
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                filmResim.Image = new Bitmap(ofd.FileName);
                resimYolu = ofd.FileName.ToString();
            }
        }

        private void filmAciklama_TextChanged(object sender, EventArgs e)
        {
            int karakterSayisi = filmAciklama.Text.Length;
            int geri = 300 - karakterSayisi;
            lblSayac.Text = karakterSayisi.ToString();

            if (geri <= 20)
            {
                lblSayac.ForeColor = Color.Red;
            }
            else
            {
                lblSayac.ForeColor = Color.Black;
            }
        }

        void oListeGetir()
        {
            string sorgu = "SELECT * FROM Tbl_Oyuncular ORDER BY ADSOYAD ASC";
            fOPanel.Controls.Clear(); // Oyuncular için paneli temizliyoruz
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                oListeAraci arac = new oListeAraci();
                arac.lblAdi.Text = oku["ADSOYAD"].ToString();
                fOPanel.Controls.Add(arac); // Oyuncuları fOPanel'e ekliyoruz
            }
            baglanti.Close();
        }

        void yListeGetir()
        {
            string sorgu = "SELECT * FROM Tbl_Yonetmenler ORDER BY ADSOYAD ASC";
            fYonPanel.Controls.Clear(); // Yönetmenler için paneli temizliyoruz
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                yListesiAraci arac = new yListesiAraci();
                arac.lblAdi.Text = oku["ADSOYAD"].ToString();
                fYonPanel.Controls.Add(arac); // Yönetmenleri fYonPanel'e ekliyoruz
            }
            baglanti.Close();
        }
        private void yeniAks_Click(object sender, EventArgs e)
        {
            if (yeniAks.ForeColor == Color.FromArgb(84, 110, 122))  // Renk kontrolü
            {
                yeniAks.ForeColor = Color.Orange;  // Tıkladığında turuncu yap
            }
            else
            {
                yeniAks.ForeColor = Color.FromArgb(84, 110, 122);  // Tekrar tıklandığında eski renge döndür
            }
        }

        private void yeniKorku_Click(object sender, EventArgs e)
        {
            if (yeniKorku.ForeColor == Color.FromArgb(84, 110, 122))
            {
                yeniKorku.ForeColor = Color.Orange;
            }
            else
            {
                yeniKorku.ForeColor = Color.FromArgb(84, 110, 122);
            }
        }

        private void yeniRomantik_Click(object sender, EventArgs e)
        {
            if (yeniRomantik.ForeColor == Color.FromArgb(84, 110, 122))
            {
                yeniRomantik.ForeColor = Color.Orange;
            }
            else
            {
                yeniRomantik.ForeColor = Color.FromArgb(84, 110, 122);
            }
        }

        private void yeniTarih_Click(object sender, EventArgs e)
        {
            if (yeniTarih.ForeColor == Color.FromArgb(84, 110, 122))
            {
                yeniTarih.ForeColor = Color.Orange;
            }
            else
            {
                yeniTarih.ForeColor = Color.FromArgb(84, 110, 122);
            }
        }

        private void yeniDrama_Click(object sender, EventArgs e)
        {
            if (yeniDrama.ForeColor == Color.FromArgb(84, 110, 122))
            {
                yeniDrama.ForeColor = Color.Orange;
            }
            else
            {
                yeniDrama.ForeColor = Color.FromArgb(84, 110, 122);
            }
        }

        private void yeniCizgiFilm_Click(object sender, EventArgs e)
        {
            if (yeniCizgiFilm.ForeColor == Color.FromArgb(84, 110, 122))
            {
                yeniCizgiFilm.ForeColor = Color.Orange;
            }
            else
            {
                yeniCizgiFilm.ForeColor = Color.FromArgb(84, 110, 122);
            }
        }


        private void turkce_Click(object sender, EventArgs e)
        {
            // Diğer etiketlerin rengini eski haline getir
            foreach (Control arac in kategoriGrp.Controls)
            {
                if (arac is Label && arac != turkce)
                {
                    if (arac.ForeColor == Color.Orange)
                    {
                        arac.ForeColor = Color.FromArgb(84, 110, 122);
                    }
                }
            }

            // Turkce etiketinin rengini kontrol et ve değiştir
            if (turkce.ForeColor == Color.FromArgb(84, 110, 122))
            {
                turkce.ForeColor = Color.Orange;
            }
            else
            {
                turkce.ForeColor = Color.FromArgb(84, 110, 122);
            }
        }

        private void italyanca_Click(object sender, EventArgs e)
        {
            // Diğer etiketlerin rengini eski haline getir
            foreach (Control arac in gbBicim.Controls)
            {
                if (arac is Label && arac != italyanca)
                {
                    if (arac.ForeColor == Color.Orange)
                    {
                        arac.ForeColor = Color.FromArgb(84, 110, 122);
                    }
                }
            }

            // Italyanca etiketinin rengini kontrol et ve değiştir
            if (italyanca.ForeColor == Color.FromArgb(84, 110, 122))
            {
                italyanca.ForeColor = Color.Orange;
            }
            else
            {
                italyanca.ForeColor = Color.FromArgb(84, 110, 122);
            }
        }

        private void almanca_Click(object sender, EventArgs e)
        {
            // Diğer etiketlerin rengini eski haline getir
            foreach (Control arac in gbBicim.Controls)
            {
                if (arac is Label && arac != almanca)
                {
                    if (arac.ForeColor == Color.Orange)
                    {
                        arac.ForeColor = Color.FromArgb(84, 110, 122);
                    }
                }
            }

            // Almanca etiketinin rengini kontrol et ve değiştir
            if (almanca.ForeColor == Color.FromArgb(84, 110, 122))
            {
                almanca.ForeColor = Color.Orange;
            }
            else
            {
                almanca.ForeColor = Color.FromArgb(84, 110, 122);
            }
        }
      private void traltyazi_Click(object sender, EventArgs e)
        {
            // Diğer etiketlerin rengini eski haline getir
            foreach (Control arac in gbBicim.Controls)
            {
                if (arac is Label && arac != traltyazi)
                {
                    if (arac.ForeColor == Color.Orange)
                    {
                        arac.ForeColor = Color.FromArgb(84, 110, 122);
                    }
                }
            }
            if (traltyazi.ForeColor == Color.FromArgb(84, 110, 122))
            {
                traltyazi.ForeColor = Color.Orange;
            }
            else
            {
                traltyazi.ForeColor = Color.FromArgb(84, 110, 122);
            }
        }

        

        private void genelizleyici_Click(object sender, EventArgs e)
        {
            foreach (Control arac in gbOzellik.Controls)
            {
                if (arac is Label && arac != genelizleyici)
                {
                    if (arac.ForeColor == Color.Orange)
                    {
                        arac.ForeColor = Color.FromArgb(84, 110, 122);
                    }
                }
            }

            if (genelizleyici.ForeColor == Color.FromArgb(84, 110, 122))
            {
                genelizleyici.ForeColor = Color.Orange;
            }
            else
            {
                genelizleyici.ForeColor = Color.FromArgb(84, 110, 122);
            }
        }

        private void olumsuzİcerik_Click(object sender, EventArgs e)
        {
            foreach (Control arac in gbOzellik.Controls)
            {
                if (arac is Label && arac != olumsuzİcerik)
                {
                    if (arac.ForeColor == Color.Orange)
                    {
                        arac.ForeColor = Color.FromArgb(84, 110, 122);
                    }
                }
            }

            if (olumsuzİcerik.ForeColor == Color.FromArgb(84, 110, 122))
            {
                olumsuzİcerik.ForeColor = Color.Orange;
            }
            else
            {
                olumsuzİcerik.ForeColor = Color.FromArgb(84, 110, 122);
            }
        }

        private void yas16_Click(object sender, EventArgs e)
        {
            foreach (Control arac in gbOzellik.Controls)
            {
                if (arac is Label && arac != yas16)
                {
                    if (arac.ForeColor == Color.Orange)
                    {
                        arac.ForeColor = Color.FromArgb(84, 110, 122);
                    }
                }
            }

            if (yas16.ForeColor == Color.FromArgb(84, 110, 122))
            {
                yas16.ForeColor = Color.Orange;
            }
            else
            {
                yas16.ForeColor = Color.FromArgb(84, 110, 122);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            foreach (Control arac in gbOzellik.Controls)
            {
                if (arac is Label && arac != label4)
                {
                    if (arac.ForeColor == Color.Orange)
                    {
                        arac.ForeColor = Color.FromArgb(84, 110, 122);
                    }
                }
            }

            if (label4.ForeColor == Color.FromArgb(84, 110, 122))
            {
                label4.ForeColor = Color.Orange;
            }
            else
            {
                label4.ForeColor = Color.FromArgb(84, 110, 122);
            }
        }
        

       

        private void button3_Click(object sender, EventArgs e)
        {
            vizyonTarihHesapla();
        }

        string vTarih = "";
        string durum = "0";
        void vizyonTarihHesapla()
        {
            vTarih=nGun.Value+"-"+nAy.Value+"-"+nYil.Value;
            
            DateTime dVTarih=Convert.ToDateTime(vTarih);
            DateTime bugunTarihi=DateTime.Today;

            //timeSpan --> Var olan 2 tarih arasındaki gün, ay, yıl ve saat gibi veriler için.
            TimeSpan tSpan = dVTarih - bugunTarihi;

            if (tSpan.TotalDays < 0)
            {
                // fark negatifse;
                MessageBox.Show("Geçmiş tarihlere ait film eklemesi yapılamaz.");
                bugunTarih();

            }
            else if (tSpan.TotalDays == 0)
            {
                MessageBox.Show(filmAdi.Text.ToString().ToUpper() + " filmi bugün vizyonda!");
                timer1.Enabled = true;
                durum = "1";

            }

            else
            {
                MessageBox.Show(filmAdi.Text.ToString().ToUpper()+tSpan.TotalDays.ToString()+" gün sonra vizyona girecek!");
                timer1.Enabled = true;
                durum = "0";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tarihh.Text=DateTime.Now.ToShortDateString();
            saat.Text=DateTime.Now.ToShortTimeString();
        }
        string yonetmen = "";
        string oyuncu = "";

        void secilenYonetmen()
        {
            yonetmen = "";  // Başlangıçta boşaltıyoruz.
            string sorgu = "SELECT * FROM Tbl_Secilenler WHERE TUR='YONETMEN'";
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                yonetmen += " ," + oku["KISI"].ToString();
            }
            baglanti.Close();
        }

        void secilenOyuncu()
        {
            oyuncu = "";  // Başlangıçta boşaltıyoruz.
            string sorgu = "SELECT * FROM Tbl_Secilenler WHERE TUR='OYUNCU'";
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                oyuncu += " ," + oku["KISI"].ToString();
            }
            baglanti.Close();
        }

        private void filmKaydetBtn_Click(object sender, EventArgs e)
        {
            turyeni();
            bicim();
            ozellik();
            // Yönetmen ve oyuncu bilgilerini çek
            secilenYonetmen();
            secilenOyuncu();

            // Alanların boş olup olmadığını kontrol et
            if (string.IsNullOrWhiteSpace(filmAdi.Text) || string.IsNullOrWhiteSpace(filmAciklama.Text) ||
                string.IsNullOrWhiteSpace(yonetmen) || string.IsNullOrWhiteSpace(oyuncu))
            {
                // Debugging amaçlı, girilen değerleri MessageBox ile yazdır
                MessageBox.Show($"Film Adı: {filmAdi.Text}\nAçıklama: {filmAciklama.Text}\nYönetmen: {yonetmen}\nOyuncu: {oyuncu}");

                // Eğer herhangi bir alan boşsa, kullanıcıya uyarı ver
                MessageBox.Show("Lütfen tüm alanları doldurduğunuzdan emin olun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Fonksiyonu sonlandır
            }

            try
            {
                // Bağlantıyı aç
                baglanti.Open();

                string sorgu = "INSERT INTO Tbl_Filmler(AD, TUR, OZELLIKLER, BICIM, YONETMEN, OYUNCU, DETAY, PUAN, AFIS, TARIH, DURUM) " +
                               "VALUES (@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9, @p10, @p11)";
                SqlCommand komut = new SqlCommand(sorgu, baglanti);

                // Parametreleri ekleyelim
                komut.Parameters.AddWithValue("@p1", filmAdi.Text.ToUpper());
                if (secilenTu.Length > 2)
                {
                    komut.Parameters.AddWithValue("@p2", secilenTu.Substring(2));
                }
                else
                {
                    komut.Parameters.AddWithValue("@p2", secilenTu);

                }

                if (secilenOzellik.Length > 2)
                {
                    komut.Parameters.AddWithValue("@p3", secilenOzellik.Substring(2));
                }
                else
                {
                    komut.Parameters.AddWithValue("@p3", secilenOzellik);

                }

                if (secilenBicim.Length > 2)
                {
                    komut.Parameters.AddWithValue("@p4", secilenBicim.Substring(2));
                }
                else
                {
                    komut.Parameters.AddWithValue("@p4", secilenBicim);

                }
                komut.Parameters.AddWithValue("@p5", yonetmen.Length > 2 ? yonetmen.Substring(2) : yonetmen);
                komut.Parameters.AddWithValue("@p6", oyuncu.Length > 2 ? oyuncu.Substring(2) : oyuncu);
                komut.Parameters.AddWithValue("@p7", filmAciklama.Text.ToUpper());
                komut.Parameters.AddWithValue("@p8", lblRatingRadio.Text);
                komut.Parameters.AddWithValue("@p9", resimYolu);
                komut.Parameters.AddWithValue("@p10", vTarih);
                komut.Parameters.AddWithValue("@p11", durum);

                // Sorguyu çalıştır
                komut.ExecuteNonQuery();

                // Bağlantıyı kapat
                baglanti.Close();

                // Kullanıcıya başarılı mesajı göster
                MessageBox.Show("Film başarılı bir şekilde kaydedildi.");
            }
            catch (Exception ex)
            {
                // Hata durumunda kullanıcıya mesaj göster
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Bağlantıyı her durumda kapat
                if (baglanti.State == System.Data.ConnectionState.Open)
                {
                    baglanti.Close();
                }
            }
        }



        string secilenTu = "";
        string secilenOzellik = "";
        string secilenBicim = "";


       

        void turyeni()
        {
            foreach (Control arac in kategoriGrp.Controls)
            {
                if (arac is Label)
                {
                    if (arac.ForeColor == Color.FromArgb(84, 110, 122))
                    {

                    }
                   else if(arac.ForeColor==Color.Orange)
                    {
                        secilenTu += " ," + arac.Text.ToString();
                    }
                }
                else
                {
                }
            }

        }




        void ozellik()
        {
            foreach (Control arac in gbOzellik.Controls)
            {
                if (arac is Label)
                {
                    if (arac.ForeColor == Color.FromArgb(84, 110, 122))
                    {

                    }
                    else
                    {
                        secilenOzellik += " ," + arac.Text.ToString();
                    }
                }
            }

        }
        void bicim()
        {
            foreach (Control arac in gbBicim.Controls)
            {
                if (arac is Label)
                {
                    if (arac.ForeColor == Color.FromArgb(84, 110, 122))
                    {

                    }
                    else
                    {
                        secilenBicim += " ," + arac.Text.ToString();
                    }
                }
            }

        }

        private void filmResmiBtn_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "RESİM SEÇME";
            ofd.Filter = "PNG|*.png|JPG|*.jpg|JPEG|*.jpeg|All Files|*.*";
            ofd.FilterIndex = 3;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //resim alma işlemi bu kısımda gerçekleşiyor.
                filmResim.Image = new Bitmap(ofd.FileName);
                resimYolu = ofd.FileName.ToString();
            }
        }

    }
}
