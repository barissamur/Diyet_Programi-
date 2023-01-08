using DiyetisyenProje.PL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiyetisyenProje.PL
{
    public partial class AnaForm : Form
    {
        DiyetDbContext db = new DiyetDbContext();
        Kullanici GirenKullanici;
        Admin GirenAdmin;
        public AnaForm()
        {
            InitializeComponent();
            YuklemeEkrani();

            DiyetDbContextSeed.Seed(db);
        }

        private void YuklemeEkrani()
        {
            SplashScreen ss = new SplashScreen();
            ss.ShowDialog();
            Hide();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            GirenKullanici = db.Kullanicilar.FirstOrDefault(x => x.KullaniciAdi == txtKullaniciAdi.Text);
            GirenAdmin = db.Adminler.FirstOrDefault(x => x.KullaniciAdi == txtKullaniciAdi.Text);

            if (chcAdmin.Checked && db.Adminler.Any(x => x.KullaniciAdi == txtKullaniciAdi.Text) && GirenAdmin.Sifre == txtSifre.Text)
            {
                string girenAdmin = txtKullaniciAdi.Text;
                AdminForm adminForm = new AdminForm(db, girenAdmin);
                adminForm.ShowDialog();
            }

            else if (db.Kullanicilar.Any(x => x.KullaniciAdi == txtKullaniciAdi.Text) && txtSifre.Text == GirenKullanici.Sifre && chcKullanici.Checked)
            {
                string girenKullanici = txtKullaniciAdi.Text;
                KullaniciGirisForm kullaniciGiris = new KullaniciGirisForm(db, girenKullanici);
                kullaniciGiris.ShowDialog();
            }

            else return;
        }

        private void llKayitOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            KayitOlForm kayitOlForm = new KayitOlForm(db);
            kayitOlForm.ShowDialog();
        }

        private void llHakkinda_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HakkindaForm hakkindaForm = new HakkindaForm();
            hakkindaForm.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sosyal Medya Hesaplarımız Bakımdadır");
        }
    }
}
