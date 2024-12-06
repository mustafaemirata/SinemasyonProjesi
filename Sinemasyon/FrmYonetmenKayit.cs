using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Sinemasyon
{
    public partial class FrmYonetmenKayit : Form
    {
        public FrmYonetmenKayit()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=EMIR\\SQLEXPRESS;Initial Catalog=DbSinemasyon;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public string resimYolu = "";
        private void btnResimEkle_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd= new OpenFileDialog();
            ofd.Title = "RESİM SEÇME";
            ofd.Filter = "PNG|*.png|JPG|*.jpg|JPEG|*.jpeg|All Files|*.*";
            ofd.FilterIndex = 3;

            if(ofd.ShowDialog() == DialogResult.OK)
            {
                //resim alma işlemi bu kısımda gerçekleşiyor.
                pbResim.Image=new Bitmap(ofd.FileName);
                resimYolu=ofd.FileName.ToString();
            }
        }
        public string cinsiyet = "0";

        private void rdErkek_CheckedChanged(object sender, EventArgs e)
        {
            cinsiyet = "0";
        }

        private void rdKadin_CheckedChanged(object sender, EventArgs e)
        {
            cinsiyet = "1";
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            
            yasHesapla();

            if (txtAd.Text!=""&&txtSoyad.Text!=""&&txtBiyografi.Text!=""&&resimYolu!="")
            {
                string adsoyad = txtAd.Text.ToUpper() + " " + txtSoyad.Text.ToUpper();
                baglanti.Open();

                SqlCommand kayit = new SqlCommand("INSERT INTO Tbl_Yonetmenler (ADSOYAD,CINSIYET,YAS,BIYOGRAFI,RESIM) VALUES (@P1,@P2,@P3,@P4,@P5)", baglanti);
                kayit.Parameters.AddWithValue("@P1", adsoyad);
                kayit.Parameters.AddWithValue("@P2", cinsiyet);
                kayit.Parameters.AddWithValue("@P3", bYas);
                kayit.Parameters.AddWithValue("@P4", txtBiyografi.Text.ToString());
                kayit.Parameters.AddWithValue("@P5", resimYolu);
                kayit.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Yönetmen kayıt işlemi başarıyla gerçekleştirildi.");
                //ARAÇ TEMİZLEME KOMUTU
                aracTemizleme();

            }
            else
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.");
            }


            baglanti.Close();
        }
        void aracTemizleme()
        {
            txtAd.Text = "";
            txtSoyad.Text = "";
            txtBiyografi.Text = "";
            nGun.Value = 1;
            nAy.Value = 1;
            nYil.Value = 1990;
            lblSayac.Text = "300";
            cinsiyet = "0";
            bYas = "00";
            pbResim.ImageLocation = @"C:\Users\Emir\Desktop\image.png";
            txtAd.Focus();  
        }
        public string bYas="0";
        void yasHesapla()
        {
            string dogum = nGun.Value.ToString() + " - " + nAy.Value.ToString() + " - " + nYil.Value.ToString();
            DateTime dogumTarihi=Convert.ToDateTime(dogum);
            DateTime bugun = DateTime.Today;
            int yas=bugun.Year-dogumTarihi.Year;

       
            bYas=yas.ToString();


        }

        private void txtBiyografi_TextChanged(object sender, EventArgs e)
        {
            int karakterSayisi = txtBiyografi.Text.Length;
            int geri = 300 - karakterSayisi;
            lblSayac.Text = karakterSayisi.ToString();

            if(geri<=20)
            {
                lblSayac.ForeColor = Color.Red; 
            }
        }
    }
}
