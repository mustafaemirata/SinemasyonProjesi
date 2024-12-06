using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.Remoting.Channels;
using System.Windows.Forms;

namespace Sinemasyon
{
    public partial class biletOlustur : Form
    {
        public biletOlustur()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=EMIR\\SQLEXPRESS;Initial Catalog=DbSinemasyon;Integrated Security=True");

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TARİHcB.Items.Clear();
            string sorgu = "SELECT DISTINCT TARIH FROM Tbl_Kontrol WHERE FILMADI=@filmadi";
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@filmadi", cbFilmAdi.Text);
            SqlDataReader oku = komut.ExecuteReader();  
            while(oku.Read())
            {
                TARİHcB.Items.Add(oku["TARIH"].ToString());
            }
            baglanti.Close();
        }



        private void TARİHcB_SelectedIndexChanged(object sender, EventArgs e)
        {
            panelSeans.Controls.Clear();
            string saatler = "";
            string sorgu = "SELECT DISTINCT SAAT FROM Tbl_Kontrol WHERE FILMADI=@filmadi AND TARIH=@tarih";
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@filmadi", cbFilmAdi.Text);
            komut.Parameters.AddWithValue("@tarih", TARİHcB.Text);

            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                saatler = oku["SAAT"].ToString();
                RadioButton rnd = new RadioButton();
                rnd.Text = saatler;
                rnd.ForeColor = Color.Orange;
                rnd.CheckedChanged += new EventHandler(SeansSaatler);
                panelSeans.Controls.Add(rnd);


            }
            baglanti.Close();
        }

        void SeansSaatler(object sender, EventArgs e)
        {
            foreach (RadioButton item in panelSeans.Controls)
            {
                if (item.Checked)
                {
                    seanslabel.Text = item.Text;
                    cbSalonAdi.Items.Clear();

                    string secilenSaat = item.Text;

                    string sorgu = "SELECT DISTINCT SALONADI FROM Tbl_Kontrol WHERE FILMADI=@filmadi AND TARIH=@tarih AND SAAT=@saat";

                    SqlCommand komut = new SqlCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@filmadi", cbFilmAdi.Text);
                    komut.Parameters.AddWithValue("@tarih", TARİHcB.Text); 
                    komut.Parameters.AddWithValue("@saat", item.Text); 

                    baglanti.Open();
                    SqlDataReader oku = komut.ExecuteReader();

                    while (oku.Read())
                    {
                        cbSalonAdi.Items.Add(oku["SALONADI"].ToString());
                    }
                    baglanti.Close();
                }

            }
        }
        private void cbSalonAdi_SelectedIndexChanged(object sender, EventArgs e)
        {
            string salonAdi = cbSalonAdi.Text.Trim();

            // İlk sorgu: Tbl_Kontrol tablosu
            string sorgu = "SELECT * FROM Tbl_Kontrol WHERE SALONADI = @salonadi";

            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@salonadi", salonAdi);

            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                string koltuklar = oku["KOLTUKLAR"].ToString();

                if (!string.IsNullOrEmpty(koltuklar))
                {
                    gelennKoltuk.Text = koltuklar;
                }
                else
                {
                    gelennKoltuk.Text = "Koltuklar mevcut değil.";
                }
            }

            baglanti.Close();

            // İkinci sorgu: Tbl_Salonlar tablosu
            string salonSorgu = "SELECT KOLTUKSAYİSİ FROM Tbl_Salonlar WHERE SALONADİ = @salonadi";

            baglanti.Open();
            SqlCommand komut2 = new SqlCommand(salonSorgu, baglanti);
            komut2.Parameters.AddWithValue("@salonadi", salonAdi);

            SqlDataReader oku2 = komut2.ExecuteReader();
            if (oku2.Read())
            {
                // KOLTUKSAYISI sütunundaki değeri lblKoltukSayisi'ne kaydet
                lblKoltukSayisi.Text = oku2["KOLTUKSAYİSİ"].ToString();
            }
            else
            {
                lblKoltukSayisi.Text = "Veri bulunamadı.";
            }

            baglanti.Close();

            koltukAyirma();

            koltukPaneli.Controls.Clear();

            int koltukSayisi;
            if (int.TryParse(lblKoltukSayisi.Text, out koltukSayisi))
            {
                int satirSayisi = koltukSayisi / 10;

                for (int i = 1; i <= koltukSayisi; i++)
                {
                    Button btn = new Button();

                    char satirHarf = (char)('A' + (i - 1) / 10);

                    int koltukNumarasi = (i - 1) % 10 + 1;

                    btn.Text = satirHarf.ToString() + koltukNumarasi.ToString();
                    btn.Name = satirHarf.ToString() + koltukNumarasi.ToString();

                    btn.Width = 50;
                    btn.Height = 130;
                    btn.BackColor = Color.White;
                    btn.ForeColor = Color.Purple;
                    btn.Click += Btn_Click;

                    if (liste.Items.Contains(btn.Text))
                    {
                        btn.Image = (System.Drawing.Image)(Properties.Resources.kirmiziKoltuk);
                        btn.ForeColor = Color.White;
                        //     btn.BackColor = Color.Red;
                    }
                    else
                    {
                        btn.Image = (System.Drawing.Image)(Properties.Resources.maviKoltuk);

                        btn.ForeColor = Color.Black;
                    }

                    koltukPaneli.Controls.Add(btn);
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.Font = new System.Drawing.Font("Segoe UI Semibold", 12);
                }
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir koltuk sayısı girin.");
            }
        }


        void koltukAyirma()
        {
            liste.Items.Clear();

            string no = gelennKoltuk.Text.Trim();

            if (string.IsNullOrEmpty(no))
            {
                return;
            }

            string[] sec = no.Split(',');

            foreach (string bulunan in sec)
            {
                if (!string.IsNullOrWhiteSpace(bulunan))
                {
                    liste.Items.Add(bulunan.Trim());
                }
            }
        }



        void sectiklerimiz()
        {
            koltuklar.Text = "";

            foreach (string item in lbBelirlenen.Items)
            {
                koltuklar.Text += "," + item;
            }
            if (koltuklar.Text.Length > 1)
            {
                koltuklar.Text = koltuklar.Text.Substring(1);
            }
        }
        void biletNoSorgula()
        {
            string sorgu = "SELECT * FROM Tbl_Biletler WHERE BARKOD=@no";

            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@no",barkod.Text.Trim());
            SqlDataReader oku = komut.ExecuteReader();
            if (!oku.Read())
            {
                kaydetme();
            }
            else
            {
                biletNoOlustur();
                baglanti.Close();
                biletNoSorgula();   
            }

            baglanti.Close();

        }
        void kaydetme()
        {
            baglanti.Close();  
            string sorgu = "INSERT INTO Tbl_Biletler (BARKOD,ADSOYAD,TELNO,KOLTUKNO,FILMADI,TARIH,SEANS,SALON,KTUR,ISLEMSAATI) VALUES(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10) ";
            baglanti.Open();
            SqlCommand kayit=new SqlCommand(sorgu, baglanti);
            kayit.Parameters.AddWithValue("@p1", barkod.Text.Trim());
            kayit.Parameters.AddWithValue("@p2", adSoyad.Text.Trim());
            kayit.Parameters.AddWithValue("@p3", telNo.Text.Trim());
            kayit.Parameters.AddWithValue("@p4", koltuklar.Text.Trim());
            kayit.Parameters.AddWithValue("@p5", cbFilmAdi.Text.Trim());
            kayit.Parameters.AddWithValue("@p6", TARİHcB.Text.Trim());
            kayit.Parameters.AddWithValue("@p7", seanslabel.Text.Trim());
            kayit.Parameters.AddWithValue("@p8", cbSalonAdi.Text.Trim());
            kayit.Parameters.AddWithValue("@p9", cbBiletTuru.Text.Trim());
            kayit.Parameters.AddWithValue("@p10", DateTime.Now.ToString());

            kayit.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Bilet başarılı şekilde oluşturuldu!");


            string sorgu2 = "UPDATE Tbl_Kontrol " +
                 "SET KOLTUKLAR = @numara " +
                 "WHERE FILMADI = @filmadi AND TARIH = @tarih AND SAAT = @saat AND SALONADI = @salonadi";

            baglanti.Open();
            SqlCommand guncelle = new SqlCommand(sorgu2, baglanti);

            if(gelennKoltuk.Text.ToString()=="")
            {
                guncelle.Parameters.AddWithValue("@numara",koltuklar.Text.ToString());  
            }
            else
            {
                guncelle.Parameters.AddWithValue("@numara", gelennKoltuk.Text.ToString()+","+koltuklar.Text.ToString());

            }

            guncelle.Parameters.AddWithValue("@filmadi", cbFilmAdi.Text.ToString());
            guncelle.Parameters.AddWithValue("@tarih", TARİHcB.Text.ToString());
            guncelle.Parameters.AddWithValue("@saat", seanslabel.Text.ToString());
            guncelle.Parameters.AddWithValue("@salonadi", cbSalonAdi.Text.ToString());

            guncelle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Güncellendi");
        }


        private void OLUSTURMA_Click(object sender, EventArgs e)
        {
           if(adSoyad.Text!=""&&barkod.Text!=""&&koltuklar.Text!=""&&telNo.Text!=""&&cbBiletTuru.Text!= "" && cbFilmAdi.Text!=""&&cbSalonAdi.Text!=""&&TARİHcB.Text!="")
            {
                biletNoSorgula();

            }
           else
            {
                MessageBox.Show("Lutfen tum alanları eksiksiz doldurun!");
            }

        }



        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn= (Button)sender;
            
            if(btn.ForeColor==Color.White)  // dolu
            {
                MessageBox.Show("Bu koltuk doludur.");
            }
            else
            {
                if(btn.ForeColor==Color.Black)
                {
                    btn.Image = (System.Drawing.Image)(Properties.Resources.sariKoltuk);
                    btn.ForeColor= Color.Brown;
                    lbBelirlenen.Items.Add(btn.Text);
                    sectiklerimiz();
                }
                else
                {
                    btn.Image = (System.Drawing.Image)(Properties.Resources.maviKoltuk);

                    btn.ForeColor = Color.Black;
                    lbBelirlenen.Items.Remove(btn.Text);
                    sectiklerimiz();

                }
            }



        }
        private void biletOlustur_Load(object sender, EventArgs e)
        {
            filmAdiGetir();
            biletNoOlustur();
        }

        void filmAdiGetir()
        {
            string sorgu = "SELECT * FROM Tbl_Filmler ORDER BY AD ASC";
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu,baglanti);  
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read()) 
            {
                string gelenTarih = oku["TARIH"].ToString();
                DateTime fTarih=Convert.ToDateTime(gelenTarih);
                DateTime bugun=DateTime.Now;

                TimeSpan timeSpan = fTarih - bugun;
                if(timeSpan.TotalDays<=0)
                {
                    cbFilmAdi.Items.Add(oku["AD"].ToString());
                }
            
            }
            baglanti.Close();
        }

        void biletNoOlustur()
        {
            Random random = new Random();
            string karakterler = "0123456789";
            string kod = "";

            for (int i = 0; i < 11; i++)
            {
                kod += karakterler[random.Next(karakterler.Length)];
            }

            barkod.Text = kod;
            MessageBox.Show(kod);
        }

      
    }
}
