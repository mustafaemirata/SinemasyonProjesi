using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Sinemasyon
{
    public partial class YonetmenListesi : UserControl
    {
        public YonetmenListesi()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=EMIR\\SQLEXPRESS;Initial Catalog=DbSinemasyon;Integrated Security=True");

        private void YonetmenListesi_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            string sorgu = "SELECT *FROM Tbl_Yonetmenler WHERE ID=@P1";
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@P1",lblID.Text);
            SqlDataReader oku = komut.ExecuteReader();

            if (oku.Read())
            {
                lblCinsiyet.Text = oku["CINSIYET"].ToString();

            }
            baglanti.Close();

            if(lblCinsiyet.Text=="1")
            {
                pbCinsiyet.ImageLocation = "C:\\Users\\Emir\\Desktop\\sinemasyonIcon\\femenine.png";
            }
            else
            {
                pbCinsiyet.ImageLocation = "C:\\Users\\Emir\\Desktop\\sinemasyonIcon\\male.png";

            }


        }

        private void btnDetay_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string sorgu = "SELECT *FROM Tbl_Yonetmenler WHERE ID=@P1";
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@P1", lblID.Text);
            SqlDataReader oku = komut.ExecuteReader();

            if (oku.Read())
            {
                MessageBox.Show(oku["BIYOGRAFI"].ToString(), oku["ADSOYAD"].ToString(),MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            baglanti.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand sil = new SqlCommand("DELETE FROM Tbl_Yonetmenler WHERE ID=@P1",baglanti);
            sil.Parameters.AddWithValue("@P1",lblID.Text);
           
            sil.ExecuteNonQuery();
            MessageBox.Show(lblAdSoyad.Text+" "+" kişisine ait kayıt silindi.");
            baglanti.Close();
            this.Hide();

        }
    }
}
