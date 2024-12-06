using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinemasyon
{
    public partial class FrmAnaForm : Form
    {
        public FrmAnaForm()
        {
            InitializeComponent();
        }
        public string kisiAd;

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmYonetmenKayit frm=new FrmYonetmenKayit();
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmYonetmenListesi frm=new FrmYonetmenListesi();    
            frm.ShowDialog();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmOyuncuKayit frm= new FrmOyuncuKayit();
            frm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmOyuncuListesi frm = new FrmOyuncuListesi();
            frm.ShowDialog(); 
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmSalonKayit frm = new FrmSalonKayit();
            frm.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FilmKayit frm = new FilmKayit();    
            frm.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FrmFilmListe frm= new FrmFilmListe();   
            frm.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            biletOlustur frm= new biletOlustur(); 
            frm.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            FrmBiletSorgulama frm=new FrmBiletSorgulama();
            frm.ShowDialog();
        }
    }
}
