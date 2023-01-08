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
    public partial class KullaniciBilgiDuzenleForm : Form
    {
        private readonly string _girenKullanici;
        private readonly DiyetDbContext _db;
        Kullanici GirenKullanici;
        DateTime dt = new DateTime(2020, 01, 01);


        public KullaniciBilgiDuzenleForm(string girenKullanici, DiyetDbContext db)
        {
            InitializeComponent();
            _girenKullanici=girenKullanici;
            _db=db;
            GirenKullanici = _db.Kullanicilar.FirstOrDefault(x => x.KullaniciAdi == _girenKullanici);
            lblKullaniciAdi.Text += _girenKullanici + " Adlı kullanıcının bilgilerini düzenle";

            BilgirleriGetir();

            rbErkek.Checked = true;

        }

        private void BilgirleriGetir()
        {
            txtAd.Text = GirenKullanici.Ad;
            txtSoyad.Text = GirenKullanici.Soyad;
            txtKulAd.Text = GirenKullanici.KullaniciAdi;
            txtSifre.Text = GirenKullanici.Sifre;
            txtKilo.Text = GirenKullanici.Kilo.ToString();
            dtpDogumTarihi.Value = GirenKullanici.DogumTarihi;
            txtBoyunCevresi.Text =GirenKullanici.BoyunCevresi.ToString();
            txtBelCevresi.Text = GirenKullanici.BelCevresi.ToString();
            txtKalcaCevresi.Text = GirenKullanici.KalcaCevresi.ToString();
            txtBoy.Text = GirenKullanici.Boy.ToString();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {

            if (!AdSoyadKontrol(txtAd.Text, txtSoyad.Text)) return;

            if (KullaniciAdiKontrol(txtKulAd.Text) && txtKulAd.Text != GirenKullanici.KullaniciAdi)
            {
                MessageBox.Show("Bu kullanıcı adı kullanılıyor");
                return;
            }

            if (txtKulAd.Text.Length < 3 || txtKulAd.Text.Length > 15)
            {
                MessageBox.Show("Kullanıcı adı 3 ile 15 karakter arasında olmalıdır");
                return;
            }

            if (!SifreKontrol(txtSifre.Text)) return;

            if (txtKilo.Text == "")
            {
                MessageBox.Show("Lütfen kilonuzu giriniz");
                return;
            }

            if (dtpDogumTarihi.Value.Year > dt.Year)
            {
                MessageBox.Show("12 yaşından büyük olmalısınız");
                return;
            }

            if (txtBoy.Text == "" || txtBoyunCevresi.Text == "" || txtBelCevresi.Text == "" || txtKalcaCevresi.Text == "")
            {
                MessageBox.Show("Lütfen bilgileri boş bırakmayınız");
                return;
            }

            GirenKullanici.Ad = txtAd.Text;
            GirenKullanici.Soyad = txtSoyad.Text;
            GirenKullanici.KullaniciAdi = txtKulAd.Text;
            GirenKullanici.Sifre = txtSifre.Text;
            GirenKullanici.Cinsiyet = rbErkek.Checked ? "Erkek" : "Kadın";
            GirenKullanici.Kilo = Convert.ToDouble(txtKilo.Text);
            GirenKullanici.DogumTarihi = dtpDogumTarihi.Value;
            GirenKullanici.BoyunCevresi = Convert.ToDouble(txtBoyunCevresi.Text);
            GirenKullanici.BelCevresi = Convert.ToDouble(txtBelCevresi.Text);
            GirenKullanici.KalcaCevresi = Convert.ToDouble(txtKalcaCevresi.Text);
            GirenKullanici.Boy = Convert.ToDouble(txtBoy.Text);

            _db.SaveChanges();

            DialogResult = DialogResult.OK;
        }

        private bool SifreKontrol(string sifre)
        {
            if (sifre.All(x => Char.IsDigit(x)) || sifre.Length < 5 || sifre.All(x => Char.IsNumber(x)) || sifre.Length > 10 || sifre.All(x => Char.IsLetter(x)))
            {
                MessageBox.Show("Şifre rakam ve harflerden oluşmalıdır.\r\nŞifreniz 5 ile 11 karkater arasında olmalıdır", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            else
                return true;
        }

        private bool AdSoyadKontrol(string ad, string soyad)
        {
            if (ad.All(x => char.IsLetter(x)) && ad.Length > 2 && soyad.Length > 2 && soyad.All(x => char.IsLetter(x)))
                return true;

            else
            {
                MessageBox.Show("AD VE SOYAD SADECE HARFLERDEN OLUŞMALIDIR!!\r\nAD VE SOYAD EN AZ 2 KARAKTERDEN OLUŞMALIDIR!!", "UYARI!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        public bool KullaniciAdiKontrol(string kullaniciAdi)
        {
            bool kullaniciKontrol = _db.Kullanicilar.Any(x => x.KullaniciAdi == kullaniciAdi);
            bool adminKontrol = _db.Adminler.Any(y => y.KullaniciAdi == kullaniciAdi);

            if (kullaniciKontrol || adminKontrol)
                return true;

            else
                return false;
        }

        private void txtKulAd_TextChanged(object sender, EventArgs e)
        {

            if (txtKulAd.Text == GirenKullanici.KullaniciAdi)
            {
                lblKulKontrol.Text = "-";
                lblKulKontrol.ForeColor = Color.Gray;

            }


            else if (KullaniciAdiKontrol(txtKulAd.Text))
            {
                lblKulKontrol.Text = "Bu kullanıcı adı kullanılıyor";
                lblKulKontrol.ForeColor = Color.Red;
            }

            else
            {
                lblKulKontrol.Text = "Bu kullanıcı adını alabilirsiniz";
                lblKulKontrol.ForeColor = Color.Green;
            }
        }
    }
}
