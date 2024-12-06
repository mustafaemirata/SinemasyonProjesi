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
    public partial class FrmFilmDetay : Form
    {
        public FrmFilmDetay()
        {
            InitializeComponent();
        }
        public string id = "0";
        SqlConnection baglanti = new SqlConnection("Data Source=EMIR\\SQLEXPRESS;Initial Catalog=DbSinemasyon;Integrated Security=True");

        private void FrmFilmDetay_Load(object sender, EventArgs e)
        {
            string sorgu = "SELECT *FROM Tbl_Filmler WHERE ID=@P1";
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@P1", id);
            SqlDataReader oku = komut.ExecuteReader();
            if (oku.Read())
            {
                filmResim.ImageLocation = oku["AFIS"].ToString();
                filmİsim.Text= oku["AD"].ToString();
                filmBicim.Text = oku["BICIM"].ToString();
                ozellik.Text = oku["OZELLIKLER"].ToString();
                filmTur.Text = oku["TUR"].ToString();
                oyuncular.Text = oku["OYUNCU"].ToString();
                filmYonetmen.Text = oku["YONETMEN"].ToString();
                vizyonTarih.Text = oku["TARIH"].ToString();
                durum.Text = oku["DURUM"].ToString();
                detay.Text = oku["DETAY"].ToString();
                filmPuan.Text = oku["PUAN"].ToString();

            }
            baglanti.Close();
            if(durum.Text=="0")
            {
                durum.Text = "Film Vizyonda!";
            }
            else
            {
                durum.Text = "Film henüz yayınlanmadı!";

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
