using DiyetisyenProje.PL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
    public partial class AdminForm : Form
    {
        private readonly DiyetDbContext _db;
        private readonly string _girenAdmin;
        Besin seciliBesin;
        Kullanici seciliKullanici;
        BesinKategori seciliBesinKategori;
        int seciliBesinId, besinIndex, seciliKullaniciId, kullaniciIndex;

        public AdminForm(DiyetDbContext db, string girenAdmin)
        {
            InitializeComponent();
            cboSirala.Items.Add("Ad Soyada göre sırala");
            cboSirala.Items.Add("Kullanıcı adına göre sırala");
            cboSirala.Items.Add("Yaşa adına göre sırala");

            _db = db;
            _girenAdmin = girenAdmin;

            cboKategoriler.DataSource = _db.BesinKategoriler.ToList();
            cboKategoriler.DisplayMember = "Ad";

            Admin admin = _db.Adminler.FirstOrDefault(x => x.KullaniciAdi == girenAdmin);

            dgvBesinler.DataSource = _db.Besinler.Select(x =>
            new
            {
                ID = x.Id,
                Ad = x.Ad,
                Kalori = x.Kalori,
                Kategori = x.BesinKategori.Ad
            }).ToList();

            dgvKullanicilar.DataSource = _db.Kullanicilar
                .Select(x =>
            new
            {
                x.Id,
                x.Ad,
                x.Soyad,
                x.KullaniciAdi,
                x.Sifre,
                x.Cinsiyet,
                x.Kilo,
                Yas = x.Yas(),
                x.BoyunCevresi,
                x.BelCevresi,
                x.KalcaCevresi,
                x.Boy,
                Liste = _db.Listeler.FirstOrDefault(y => y.Id == x.ListeId).ListeAdi
            }).ToList();

            lblAdminAdSoyad.Text = "Admin: " + admin.Ad + " " + admin.Soyad + " (" + admin.KullaniciAdi + ")";
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                Besin besin = new Besin()
                {
                    Ad = txtAd.Text,
                    Kalori = Convert.ToDouble(txtKalori.Text),
                    BesinKategoriId = seciliBesinKategori.Id
                };

                _db.Besinler.Add(besin);
                _db.SaveChanges();

                dgvBesinler.DataSource = _db.Besinler.Select(x =>
          new
          {
              ID = x.Id,
              Ad = x.Ad,
              Kalori = x.Kalori,
              Kategori = x.BesinKategori.Ad
          }).ToList();
            }

            catch (Exception)
            {
                MessageBox.Show("Hatalı deneme yaptınız");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                _db.Besinler.Remove(seciliBesin);
                _db.SaveChanges();

                dgvBesinler.DataSource = _db.Besinler.Select(x =>
          new
          {
              ID = x.Id,
              Ad = x.Ad,
              Kalori = x.Kalori,
              Kategori = x.BesinKategori.Ad
          }).ToList();
            }

            catch (Exception)
            {
                MessageBox.Show("Hatalı deneme yaptınız");
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                seciliBesin.Ad = txtAd.Text;
                seciliBesin.Kalori = Convert.ToDouble(txtKalori.Text);
                seciliBesin.BesinKategori = (BesinKategori)cboKategoriler.SelectedItem;
                _db.SaveChanges();

                besinIndex = seciliBesinId;
                dgvBesinler.DataSource = _db.Besinler.Select(x =>
           new
           {
               ID = x.Id,
               Ad = x.Ad,
               Kalori = x.Kalori,
               Kategori = x.BesinKategori.Ad
           }).ToList();

                //dgvBesinler.Rows[besinIndex - 1].Selected = true;
                dgvBesinler.Rows[besinIndex - 1].Cells[0].Selected = true;
            }

            catch (Exception)
            {
                MessageBox.Show("Hatalı deneme yaptınız");
            }
        }

        private void dgvBesinler_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvBesinler.SelectedRows.Count == 0) return;

            seciliBesinId = (int)dgvBesinler.SelectedRows[0].Cells[0].Value;
            seciliBesin = _db.Besinler.FirstOrDefault(x => x.Id == seciliBesinId);

            txtAd.Text = seciliBesin.Ad;
            txtKalori.Text = seciliBesin.Kalori.ToString();
            cboKategoriler.SelectedItem = seciliBesin.BesinKategori;
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            try
            {
                HashSet<Besin> arananBesinler = new HashSet<Besin>();
                List<Besin> aramaBesin = new List<Besin>();
                dgvBesinler.DataSource = null;

                if (chcId.Checked && txtId.Text != "")
                    aramaBesin.AddRange(_db.Besinler.Where(x => x.Id == Convert.ToInt32(txtId.Text)).ToList());

                if (chcBesinAd.Checked && txtAd.Text != "")
                    aramaBesin.AddRange(_db.Besinler.Where(x => x.Ad.Contains(txtAd.Text)).ToList());

                if (chcKalori.Checked && txtKalori.Text != "")
                    aramaBesin.AddRange(_db.Besinler.Where(x => x.Kalori == Convert.ToDouble(txtKalori.Text)).ToList());

                if (!chcId.Checked && !chcBesinAd.Checked && !chcKalori.Checked)
                {
                    MessageBox.Show("Arama kriteri seçiniz");
                    return;
                }

                foreach (Besin item in aramaBesin)
                    arananBesinler.Add(item);

                dgvBesinler.DataSource = arananBesinler.ToList();
            }

            catch (Exception)
            {
                MessageBox.Show("Hatalı deneme yaptınız");
            }
        }

        private void btnKulGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)dgvKullanicilar.SelectedRows[0].Cells[0].Value;
                seciliKullanici = _db.Kullanicilar.Find(id);

                seciliKullanici.Ad = txtKullaniciAd.Text;
                seciliKullanici.Soyad = txtKullaniciSoyad.Text;
                seciliKullanici.KullaniciAdi = txtKulAdi.Text;
                seciliKullanici.Sifre = txtSifre.Text;
                seciliKullanici.Cinsiyet = cboCinsiyet.Text;
                seciliKullanici.Kilo = Convert.ToDouble(txtKilo.Text);
                seciliKullanici.DogumTarihi = dtpDogumTarihi.Value;
                seciliKullanici.Boy =  Convert.ToDouble(txtBoy.Text);
                seciliKullanici.BelCevresi =  Convert.ToDouble(txtBelCevresi.Text);
                seciliKullanici.BoyunCevresi =  Convert.ToDouble(txtBoyunCevresi.Text);
                seciliKullanici.KalcaCevresi =  Convert.ToDouble(txtKalcaCevresi.Text);

                _db.SaveChanges();

                kullaniciIndex = seciliKullaniciId;

                dgvKullanicilar.DataSource = _db.Kullanicilar
               .Select(x =>
           new
           {
               x.Id,
               x.Ad,
               x.Soyad,
               x.KullaniciAdi,
               x.Sifre,
               x.Cinsiyet,
               x.Kilo,
               Yas = x.Yas(),
               x.BoyunCevresi,
               x.BelCevresi,
               x.KalcaCevresi,
               x.Boy,
               Liste = _db.Listeler.FirstOrDefault(y => y.Id == x.ListeId).ListeAdi
           }).ToList();

                dgvKullanicilar.Rows[kullaniciIndex - 1].Selected = true;
                dgvKullanicilar.Rows[kullaniciIndex - 1].Cells[0].Selected = true;
            }

            catch (Exception)
            {
                MessageBox.Show("Hatalı deneme yaptınız");
            }
        }

        private void dgvKullanicilar_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvKullanicilar.SelectedRows.Count == 0) return;

            seciliKullaniciId = (int)dgvKullanicilar.SelectedRows[0].Cells[0].Value;

            seciliKullanici = _db.Kullanicilar.FirstOrDefault(x => x.Id == seciliKullaniciId);

            txtKullaniciAd.Text = seciliKullanici.Ad;
            txtKullaniciSoyad.Text = seciliKullanici.Soyad;
            txtKulAdi.Text = seciliKullanici.KullaniciAdi;
            txtSifre.Text = seciliKullanici.Sifre;
            cboCinsiyet.Text = seciliKullanici.Cinsiyet;
            txtKilo.Text = seciliKullanici.Kilo.ToString();
            dtpDogumTarihi.Value = seciliKullanici.DogumTarihi;
            txtBoy.Text = seciliKullanici.Boy.ToString();
            txtBoyunCevresi.Text = seciliKullanici.BoyunCevresi.ToString();
            txtBelCevresi.Text = seciliKullanici.BelCevresi.ToString();
            txtKalcaCevresi.Text = seciliKullanici.KalcaCevresi.ToString();

        }

        private void btnKulSil_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dgvKullanicilar.SelectedRows[0].Cells[0].Value);
                var seciliKullanici = _db.Kullanicilar.Find(id);

                _db.Kullanicilar.Remove(seciliKullanici);
                _db.SaveChanges();

                dgvKullanicilar.DataSource = _db.Kullanicilar
               .Select(x =>
           new
           {
               x.Id,
               x.Ad,
               x.Soyad,
               x.KullaniciAdi,
               x.Sifre,
               x.Cinsiyet,
               x.Kilo,
               Yas = x.Yas(),
               x.BoyunCevresi,
               x.BelCevresi,
               x.KalcaCevresi,
               x.Boy,
               Liste = _db.Listeler.FirstOrDefault(y => y.Id == x.ListeId).ListeAdi
           }).ToList();
            }

            catch (Exception)
            {
                MessageBox.Show("Hatalı deneme yaptınız");
            }
        }

        private void cboSirala_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (cboSirala.SelectedIndex)
            {
                case 0:
                    dgvKullanicilar.DataSource = _db.Kullanicilar.ToList();

                    break;

                case 1:
                    dgvKullanicilar.DataSource = _db.Kullanicilar.ToList();
                    break;

                case 2:
                    dgvKullanicilar.DataSource = _db.Kullanicilar.ToList();
                    break;

                default:
                    break;
            }
        }

        private void cboKategoriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            seciliBesinKategori = (BesinKategori)cboKategoriler.SelectedItem;
        }
    }
}
