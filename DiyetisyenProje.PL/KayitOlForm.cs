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
    public partial class KayitOlForm : Form
    {
        private readonly DiyetDbContext _db;
        DateTime dt = new DateTime(2020, 01, 01);

        public KayitOlForm(DiyetDbContext db)
        {
            InitializeComponent();
            _db=db;
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            if (!AdSoyadKontrol(txtAd.Text, txtSoyad.Text)) return;

            if (KullaniciAdiKontrol(txtKulAd.Text))
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

            if (!chcErkek.Checked && !chcKadin.Checked)
            {
                MessageBox.Show("Lütfen cinsiyetinizi seçiniz");
                return;
            }

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

            if (txtBoy.Text == "" || txtBoyunCevre.Text == "" || txtBelCevre.Text == "" || txtKalcaCevre.Text == "")
            {
                MessageBox.Show("Lütfen bilgileri boş bırakmayınız");
                return;
            }

            try
            {
                Kullanici kullanici = new Kullanici()
                {
                    Ad = txtAd.Text,
                    Soyad= txtSoyad.Text,
                    Boy = Convert.ToDouble(txtBoy.Text),
                    Kilo =Convert.ToDouble(txtKilo.Text),
                    Cinsiyet = chcErkek.Checked ? "Erkek" : "Kadın",
                    KullaniciAdi = txtKulAd.Text,
                    Sifre = txtSifre.Text,
                    DogumTarihi = dtpDogumTarihi.Value,
                    BoyunCevresi = Convert.ToDouble(txtBoyunCevre.Text),
                    BelCevresi = Convert.ToDouble(txtBelCevre.Text),
                    KalcaCevresi = Convert.ToDouble(txtKalcaCevre.Text)
                };

                _db.Kullanicilar.Add(kullanici);
                _db.SaveChanges();
                DialogResult dr = DialogResult.OK;
                Temizle();
            }
            catch (Exception)
            {
                MessageBox.Show("Hatalı giriş yaptınız");
            }
        }

        private void txtKulAd_TextChanged(object sender, EventArgs e)
        {

            if (KullaniciAdiKontrol(txtKulAd.Text))
            {
                lblKullaniciKontrol.Text = "Bu kullanıcı adı kullanılıyor";
                lblKullaniciKontrol.ForeColor = Color.Red;
            }

            else
            {
                lblKullaniciKontrol.Text = "Kullanıcı adını alabilirsiniz";
                lblKullaniciKontrol.ForeColor = Color.Green;
            }
        }

        private void Temizle()
        {
            txtAd.Text = txtSoyad.Text = txtBoy.Text = txtKilo.Text = txtKulAd.Text = txtSifre.Text = txtBoyunCevre.Text = txtBelCevre.Text = txtKalcaCevre.Text = "";
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

        private bool KullaniciAdiKontrol(string kullaniciAdi)
        {
            bool kullaniciKontrol = _db.Kullanicilar.Any(x => x.KullaniciAdi == kullaniciAdi);
            bool adminKontrol = _db.Adminler.Any(y => y.KullaniciAdi == kullaniciAdi);

            if (kullaniciKontrol || adminKontrol)
                return true;

            else
                return false;

        }


    }
}
