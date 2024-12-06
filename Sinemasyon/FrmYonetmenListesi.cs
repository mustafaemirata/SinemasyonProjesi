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
    public partial class FrmYonetmenListesi : Form
    {
        public FrmYonetmenListesi()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=EMIR\\SQLEXPRESS;Initial Catalog=DbSinemasyon;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmYonetmenListesi_Load(object sender, EventArgs e)
        {
            listePaneli.Controls.Clear();
            baglanti.Open();
            string sorgu = "SELECT *FROM Tbl_Yonetmenler ORDER BY ADSOYAD ASC";
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader oku= komut.ExecuteReader();

            while(oku.Read())
            {
                YonetmenListesi arac=new YonetmenListesi();
                arac.lblAdSoyad.Text = oku["ADSOYAD"].ToString();
                arac.lblID.Text = oku["ID"].ToString();
                arac.imGE.ImageLocation = oku["RESIM"].ToString();
                
                listePaneli.Controls.Add(arac);
            }


            baglanti.Close();
        }

        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            listePaneli.Controls.Clear();
            baglanti.Open();
            SqlCommand ara= new SqlCommand("SELECT * FROM Tbl_Yonetmenler WHERE ADSOYAD LIKE '%"+txtArama.Text+"%'",baglanti);
            SqlDataReader oku =ara.ExecuteReader();

            while(oku.Read())
            {
                YonetmenListesi arac = new YonetmenListesi();
                arac.lblAdSoyad.Text = oku["ADSOYAD"].ToString();
                arac.lblID.Text = oku["ID"].ToString();
                arac.imGE.ImageLocation = oku["RESIM"].ToString();

                listePaneli.Controls.Add(arac);
            }
            baglanti.Close( );  
        }

       
    }
}
