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
    public partial class FrmFilmListe : Form
    {
        public FrmFilmListe()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=EMIR\\SQLEXPRESS;Initial Catalog=DbSinemasyon;Integrated Security=True");

        private void FrmFilmListe_Load(object sender, EventArgs e)
        {
            listePaneli.Controls.Clear();
            string sorgu = "SELECT * FROM Tbl_Filmler ORDER BY AD ASC";
            baglanti.Open();

            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader oku=komut.ExecuteReader();

            while (oku.Read())
            {
                filmListesi arac = new filmListesi();
                listePaneli.Controls.Add(arac);
                arac.lblFilmAdi.Text = oku["AD"].ToString();
                arac.filmResim.ImageLocation = oku["AFIS"].ToString();
                arac.LBLıd.Text = oku["ID"].ToString();

                listePaneli.Controls.Add(arac);
            
            }

            baglanti.Close();

        }

        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            listePaneli.Controls.Clear();
            baglanti.Open();
            SqlCommand ara = new SqlCommand("SELECT * FROM Tbl_Filmler WHERE AD LIKE '%" + txtArama.Text + "%' collate Turkish_CI_AS", baglanti);
            SqlDataReader oku = ara.ExecuteReader();

            while (oku.Read())
            {
                filmListesi arac = new filmListesi();
                listePaneli.Controls.Add(arac);
                arac.lblFilmAdi.Text = oku["AD"].ToString();
                arac.filmResim.ImageLocation = oku["AFIS"].ToString();
                arac.LBLıd.Text = oku["ID"].ToString();

                listePaneli.Controls.Add(arac);
            }
            baglanti.Close();
        }
    }
}
