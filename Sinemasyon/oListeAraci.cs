using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Sinemasyon
{
    public partial class oListeAraci : UserControl
    {
        public oListeAraci()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=EMIR\SQLEXPRESS;Initial Catalog=DbSinemasyon;Integrated Security=True");

        private bool isSelected = false; // Öğenin seçili olup olmadığını belirleyen bir bayrak

        private void lblAdi_Click(object sender, EventArgs e)
        {
            try
            {
                // Eğer öğe daha önce seçilmemişse, yazı rengini turuncu yap
                if (!isSelected)
                {
                    lblAdi.ForeColor = Color.Orange; // Yazıyı turuncu yap
                    isSelected = true; // Seçildi olarak işaretle

                    // Bağlantı açık mı kontrol et
                    if (baglanti.State == System.Data.ConnectionState.Closed)
                    {
                        baglanti.Open(); // Bağlantıyı aç
                    }

                    // Veritabanına ekleme işlemi
                    SqlCommand cmd = new SqlCommand("INSERT INTO Tbl_Secilenler (KISI, TUR) VALUES (@kisi, @tur)", baglanti);
                    cmd.Parameters.AddWithValue("@kisi", lblAdi.Text);
                    cmd.Parameters.AddWithValue("@tur", "OYUNCU");
                    cmd.ExecuteNonQuery(); // Sorguyu çalıştır
                }
                else // Eğer öğe zaten seçilmişse, yazı rengini eski haline (siyah) döndür
                {
                    lblAdi.ForeColor = Color.Black; // Yazıyı siyah yap
                    isSelected = false; // Seçimi kaldır

                    // Bağlantı açık mı kontrol et
                    if (baglanti.State == System.Data.ConnectionState.Closed)
                    {
                        baglanti.Open(); // Bağlantıyı aç
                    }

                    // Veritabanından silme işlemi
                    SqlCommand cmd = new SqlCommand("DELETE FROM Tbl_Secilenler WHERE KISI = @kisi AND TUR = @tur", baglanti);
                    cmd.Parameters.AddWithValue("@kisi", lblAdi.Text);
                    cmd.Parameters.AddWithValue("@tur", "OYUNCU");
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
    }
}
