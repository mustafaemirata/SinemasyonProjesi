using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Sinemasyon
{
    public partial class FrmOyuncuListesi : Form
    {
        public FrmOyuncuListesi()
        {
            InitializeComponent();
        }

        private readonly SqlConnection baglanti = new SqlConnection("Data Source=EMIR\\SQLEXPRESS;Initial Catalog=DbSinemasyon;Integrated Security=True");

        private void FrmOyuncuListesi_Load(object sender, EventArgs e)
        {
            ListeyiDoldur();
        }

        private void ListeyiDoldur()
        {
            try
            {
                listePaneli.Controls.Clear();
                baglanti.Open();

                string sorgu = "SELECT * FROM Tbl_Oyuncular ORDER BY ADSOYAD ASC";
                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                SqlDataReader oku = komut.ExecuteReader();

                while (oku.Read())
                {
                    OyuncuListesi oyuncu = new OyuncuListesi
                    {
                        lblAdSoyad = { Text = oku["ADSOYAD"].ToString() },
                        lblID = { Text = oku["ID"].ToString() },
                        imGE = { ImageLocation = oku["RESIM"].ToString() }
                    };

                    listePaneli.Controls.Add(oyuncu);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (baglanti.State == System.Data.ConnectionState.Open)
                {
                    baglanti.Close();
                }
            }
        }

        private void txtArama_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AramaBtn_TextChanged(object sender, EventArgs e)
        {
            try
            {
                listePaneli.Controls.Clear();
                baglanti.Open();

                string sorgu = "SELECT * FROM Tbl_Oyuncular WHERE ADSOYAD LIKE @P1";
                SqlCommand ara = new SqlCommand(sorgu, baglanti);
                ara.Parameters.AddWithValue("@P1", "%" + AramaBtn.Text + "%");

                SqlDataReader oku = ara.ExecuteReader();

                while (oku.Read())
                {
                    OyuncuListesi oyuncu = new OyuncuListesi
                    {
                        lblAdSoyad = { Text = oku["ADSOYAD"].ToString() },
                        lblID = { Text = oku["ID"].ToString() },
                        imGE = { ImageLocation = oku["RESIM"].ToString() }
                    };

                    listePaneli.Controls.Add(oyuncu);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (baglanti.State == System.Data.ConnectionState.Open)
                {
                    baglanti.Close();
                }
            }
        }
    }
}
