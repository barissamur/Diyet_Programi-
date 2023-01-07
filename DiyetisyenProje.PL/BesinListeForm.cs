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
    public partial class BesinListeForm : Form
    {
        private readonly DiyetDbContext _db;
        private readonly string _girenKullaniciAd;

        Besin seciliBesin;
        Besin seciliBesinSil;
        Kullanici girenKullanici;
        List<Besin> liste = new List<Besin>();
        BesinKategori seciliKategori;

        public BesinListeForm(DiyetDbContext db, string girenKullaniciAd)
        {
            InitializeComponent();
            _db=db;
            _girenKullaniciAd=girenKullaniciAd;
            lboxBesinler.DataSource = _db.Besinler.ToList();
            girenKullanici = _db.Kullanicilar.FirstOrDefault(x => x.KullaniciAdi == _girenKullaniciAd);
            //cboxKategoriler.DataSource = _db.BesinKategoriler.ToList();

            foreach (var item in _db.BesinKategoriler)
            {
                cboxKategoriler.Items.Add(item);
            }

            cboxKategoriler.DisplayMember = "Ad";
            cboxKategoriler.Items.Add("Hepsi");
            cboxKategoriler.SelectedItem = "Hepsi";
        }

        private void btnAktar_Click(object sender, EventArgs e)
        {
            if (seciliBesin != null)
            {
                liste.Add(seciliBesin);
                lboxSecilenler.DataSource = liste.ToList();
            }
        }

        private void lboxBesinler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lboxBesinler.SelectedIndex != -1)
            {
                seciliBesin = (Besin)lboxBesinler.SelectedItems[0];
                _db.SaveChanges();
                lblSeciliBesin.Text = seciliBesin.ToString();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (seciliBesinSil != null)
            {
                liste.Remove(seciliBesinSil);
                _db.SaveChanges();
                lboxSecilenler.DataSource = liste.ToList();
            }
        }

        private void lboxSecilenler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lboxSecilenler.SelectedIndex != -1)
            {
                seciliBesinSil = (Besin)lboxSecilenler.SelectedItems[0];
                lblSecilBesinSil.Text = seciliBesinSil.ToString();
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtListeAd.Text.Length > 14)
            {
                MessageBox.Show("Liste Adınız 15 harften büyük olmalıdır");
                txtListeAd.Text = "";
                return;
            }

            if (txtListeAd.Text.Length < 3)
            {
                MessageBox.Show("Liste Adınız 3 harften küçük olmamalıdır");
                return;
            }

            Liste liste = new Liste() { ListeAdi = txtListeAd.Text, KullaniciId = girenKullanici.Id };
   

            foreach (Besin item in lboxSecilenler.Items)
            {
                ListeBesin listeBesin = new ListeBesin()
                {
                    Liste = liste,
                    Besin = item
                };
                _db.ListeBesinler.Add(listeBesin);
            }

            _db.Listeler.Add(liste);
            _db.SaveChanges();

            ListeTemizle();
        }

        private void ListeTemizle()
        {
            lboxSecilenler.SelectedIndex = -1;
            txtListeAd.Text = "";
            lboxSecilenler.DataSource = null;
        }

        private void txtBesinAra_TextChanged(object sender, EventArgs e)
        {
            lboxBesinler.DataSource = null;

            lboxBesinler.DataSource = _db.Besinler.Where(x => x.Ad.Contains(txtBesinAra.Text)).ToList();
        }

        private void cboxKategoriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxKategoriler.SelectedItem.ToString() == "Hepsi")
            {
                lboxBesinler.DataSource = _db.Besinler.ToList();
                return;
            }
            seciliKategori = (BesinKategori)cboxKategoriler.SelectedItem;
            lboxBesinler.DataSource = _db.Besinler.Where(x => x.BesinKategoriId == seciliKategori.Id).ToList();

        }
    }
}
