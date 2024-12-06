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
    public partial class FrmSalonKayit : Form
    {
        public FrmSalonKayit()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=EMIR\\SQLEXPRESS;Initial Catalog=DbSinemasyon;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnResimEkle_Click(object sender, EventArgs e)
        {
            if (salonAd.Text != "" && koltukNo.Text != "")
            {
                try
                {
                    baglanti.Open();
                    SqlCommand kaydet = new SqlCommand("INSERT INTO Tbl_Salonlar (SALONADİ, KOLTUKSAYİSİ) VALUES (@P1, @P2)", baglanti);
                    kaydet.Parameters.AddWithValue("@P1", salonAd.Text.ToUpper());
                    kaydet.Parameters.AddWithValue("@P2", koltukNo.Text);
                    kaydet.ExecuteNonQuery();
                    MessageBox.Show("Salon kaydetme işlemi başarılı şekilde gerçekleştirildi.");
                    salonAd.Text = "";
                    koltukNo.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veritabanına bağlanırken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    baglanti.Close();
                }
            }
            else
            {
                MessageBox.Show("Lütfen alanları doldurunuz.");
            }
        }

        private void FrmSalonKayit_Load(object sender, EventArgs e)
        {
            try
            {
                salonPanel.Controls.Clear();
                baglanti.Open();
                SqlCommand komut = new SqlCommand("SELECT * FROM Tbl_Salonlar ORDER BY SALONADİ ASC", baglanti);
                SqlDataReader oku = komut.ExecuteReader();

                while (oku.Read())
                {
                    SalonListesi arac = new SalonListesi();
                    arac.lblSalonAdi.Text = oku["SALONADİ"].ToString();
                    arac.lblKoltukSayisi.Text = "Koltuk Sayısı: " + oku["KOLTUKSAYİSİ"].ToString();
                    salonPanel.Controls.Add(arac);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Verileri yüklerken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                baglanti.Close();
            }
        }
       

        private void kapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
