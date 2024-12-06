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
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=EMIR\\SQLEXPRESS;Initial Catalog=DbSinemasyon;Integrated Security=True");


        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //baglanti.Open();
            //if (baglanti.State == ConnectionState.Open)
            //{
            //    Mess
            //
            //    ageBox.Show("Bağlantı Başarılı.");
            //}

            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM Tbl_Kullanicilar WHERE KAD = @P1 AND KSIFRE = @P2", baglanti); komut.Parameters.AddWithValue("@P1",kullaniciAdiTextBox.Text);
            komut.Parameters.AddWithValue("@P2",sifreTextbox.Text);

            SqlDataReader oku=komut.ExecuteReader();

            if (oku.Read()) 
            {
               FrmAnaForm frm= new FrmAnaForm();
                frm.Show();
                frm.kisiAd = oku[3].ToString();
                this.Hide();


            }
            else
            {
                MessageBox.Show("Girilen bilgiler hatalı!");
            }
            kullaniciAdiTextBox.Text = "";
            sifreTextbox.Text = "";
            kullaniciAdiTextBox.Focus();


        }

       
    }
}
