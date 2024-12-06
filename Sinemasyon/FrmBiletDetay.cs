using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinemasyon
{
    public partial class FrmBiletDetay : Form
    {
        public FrmBiletDetay()
        {
            InitializeComponent();
        }
       public string biletNo = "";
        SqlConnection baglanti = new SqlConnection("Data Source=EMIR\\SQLEXPRESS;Initial Catalog=DbSinemasyon;Integrated Security=True");

        private void FrmBiletDetay_Load(object sender, EventArgs e)
        {
            lblBiletNo.Text = biletNo;
            lblBiletNo2.Text = biletNo; 
            barkodNoOlustur();
            bilgiGetir();
        }

        void bilgiGetir()
        {
            string sorgu = "SELECT *FROM Tbl_Biletler WHERE BARKOD=@kod";
            baglanti.Open();
            SqlCommand getir = new SqlCommand(sorgu, baglanti);
            getir.Parameters.AddWithValue("@kod", biletNo);
            SqlDataReader oku = getir.ExecuteReader();

            if(oku.Read())
            {
                lblFilmAdi.Text = oku["FILMADI"].ToString();    
                film.Text = oku["FILMADI"].ToString();
                telefonNo.Text = oku["TELNO"].ToString();
                adSoyad.Text = oku["ADSOYAD"].ToString();
                lblSalon.Text = oku["SALON"].ToString();
                salonSeans.Text = oku["SALON"].ToString() +" / " +oku["SEANS"].ToString();
                biletTur.Text= oku["KTUR"].ToString();
                lblTarihSaat.Text=oku["TARIH"].ToString();
                tarih.Text= oku["TARIH"].ToString();
                lblIslemTarihi.Text= oku["TARIH"].ToString();
                lblKoltuk.Text = oku["KOLTUKNO"].ToString() ;
                lblKoltuk2.Text = oku["KOLTUKNO"].ToString();




            }

            baglanti.Close();

        }



        void barkodNoOlustur()
        {
            Random random = new Random();
            string karakterler = "0123456789";
            string kod = "";

            for (int i = 0; i < 11; i++)
            {
                kod += karakterler[random.Next(karakterler.Length)];
            }

            lblBarkod1.Text = kod.ToString();
            lblBarkod2.Text = kod.ToString();

            MessageBox.Show(kod);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
