using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Sinemasyon
{
    public partial class yListesiAraci : UserControl
    {
        public yListesiAraci()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=EMIR\SQLEXPRESS;Initial Catalog=DbSinemasyon;Integrated Security=True");

        // Seçim durumu kontrolü için bool değişkeni
        private bool isSelected = false;

        private void lblAdi_MouseMove(object sender, MouseEventArgs e)
        {
            lblAdi.Font = new Font(lblAdi.Font.Name, 8, FontStyle.Underline);
        }

        private void lblAdi_MouseLeave(object sender, EventArgs e)
        {
            lblAdi.Font = new Font(lblAdi.Font.Name, 8, FontStyle.Regular);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            lblAdi.Font = new Font(lblAdi.Font.Name, 8, FontStyle.Bold);
        }

        private void lblAdi_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open(); // Bağlantıyı aç

                if (!isSelected)
                {
                    // Eğer öğe seçilmemişse, yazı rengini turuncu yap
                    lblAdi.ForeColor = Color.Orange;
                    isSelected = true;  // Seçildi olarak işaretle

                    // Veritabanına ekleme işlemi
                    SqlCommand cmd = new SqlCommand("INSERT INTO Tbl_Secilenler (KISI, TUR) VALUES (@kisi, @tur)", baglanti);
                    cmd.Parameters.AddWithValue("@kisi", lblAdi.Text);
                    cmd.Parameters.AddWithValue("@tur", "YONETMEN");
                    cmd.ExecuteNonQuery(); // Sorguyu çalıştır
                }
                else
                {
                    // Eğer öğe zaten seçilmişse, yazı rengini eski haline (siyah) döndür
                    lblAdi.ForeColor = Color.Black;
                    isSelected = false;  // Seçimi kaldır

                    // Veritabanından silme işlemi
                    SqlCommand cmd = new SqlCommand("DELETE FROM Tbl_Secilenler WHERE KISI = @kisi AND TUR = @tur", baglanti);
                    cmd.Parameters.AddWithValue("@kisi", lblAdi.Text);
                    cmd.Parameters.AddWithValue("@tur", "YONETMEN");
                    cmd.ExecuteNonQuery(); // Sorguyu çalıştır
                }
            }
            catch (Exception ex)
            {
                // Hata durumunda kullanıcıya bilgi ver
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                // Bağlantıyı her durumda kapat
                if (baglanti.State == System.Data.ConnectionState.Open)
                {
                    baglanti.Close(); // Bağlantıyı kapat
                }
            }
        }

        private void yListesiAraci_Load(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();

                SqlCommand sql = new SqlCommand("SELECT * FROM Tbl_Secilenler WHERE KISI = @Kisi AND TUR = @Tur", baglanti);
                sql.Parameters.AddWithValue("@Kisi", lblAdi.Text);
                sql.Parameters.AddWithValue("@Tur", "YONETMEN");

                SqlDataReader OKU = sql.ExecuteReader();

                if (OKU.Read())
                {
                    lblAdi.ForeColor = Color.Orange; // Seçili ise turuncu yap
                }
                else
                {
                    lblAdi.ForeColor = Color.Black; // Seçili değilse siyah yap
                }
            }
            catch (Exception ex)
            {
                // Hata durumunda kullanıcıya bilgi ver
                MessageBox.Show("Veritabanı hatası: " + ex.Message);
            }
            finally
            {
                // Bağlantıyı her durumda kapat
                if (baglanti.State == System.Data.ConnectionState.Open)
                {
                    baglanti.Close(); // Bağlantıyı kapat
                }
            }
        }
    }
}
