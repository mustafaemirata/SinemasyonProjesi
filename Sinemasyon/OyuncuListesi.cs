using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Sinemasyon
{
    public partial class OyuncuListesi : UserControl
    {
        public OyuncuListesi()
        {
            InitializeComponent();
        }

        private readonly SqlConnection baglanti = new SqlConnection("Data Source=EMIR\\SQLEXPRESS;Initial Catalog=DbSinemasyon;Integrated Security=True");

        private void OyuncuListesi_Load(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(lblID.Text))
                {
                    MessageBox.Show("ID değeri atanmadı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                baglanti.Open();
                string sorgu = "SELECT * FROM Tbl_Oyuncular WHERE ID = @P1";
                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@P1", lblID.Text);

                SqlDataReader oku = komut.ExecuteReader();

                if (oku.Read())
                {
                    lblCinsiyet.Text = oku["CINSIYET"].ToString();
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

            if (lblCinsiyet.Text == "1")
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
           
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Basildi.");
            
        }

        private void silmeIslemi_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(lblID.Text))
                {
                    MessageBox.Show("ID değeri atanmadı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                baglanti.Open();
                SqlCommand sil = new SqlCommand("DELETE FROM Tbl_Oyuncular WHERE ID = @P1", baglanti);
                sil.Parameters.AddWithValue("@P1", lblID.Text);

                sil.ExecuteNonQuery();
                MessageBox.Show(lblAdSoyad.Text + " kişisine ait kayıt silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
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

        private void DetayButon_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(lblID.Text))
                {
                    MessageBox.Show("ID değeri atanmadı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                baglanti.Open();
                string sorgu = "SELECT * FROM Tbl_Oyuncular WHERE ID = @P1";
                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@P1", lblID.Text);

                SqlDataReader oku = komut.ExecuteReader();

                if (oku.Read())
                {
                    MessageBox.Show(oku["BIYOGRAFI"].ToString(), oku["ADSOYAD"].ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information);
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
