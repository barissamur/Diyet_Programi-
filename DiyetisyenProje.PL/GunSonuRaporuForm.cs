using DiyetisyenProje.PL.Entities;
using Microsoft.EntityFrameworkCore;
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
    public partial class GunSonuRaporuForm : Form
    {
        private readonly DiyetDbContext _db;
        private readonly string _girenKullanici;
        Kullanici GirenKullanici;
        List<BitenListe> liste;
        double gunlukTopKalori = 0;
        public GunSonuRaporuForm(DiyetDbContext db, string girenKullanici)
        {
            InitializeComponent();
            _db=db;
            _girenKullanici=girenKullanici;
            GirenKullanici = db.Kullanicilar.FirstOrDefault(x => x.KullaniciAdi.Contains(girenKullanici));


            liste = _db.BitenListeler
                .Include(x => x.Kullanici)
                .Include(x => x.Liste)
                .Where(x => x.KullaniciId == GirenKullanici.Id && x.BitisTarihi.Day == dtpTarihSec.Value.Day).ToList();

            if (liste.Count > 0)
            {
                foreach (var item in liste)
                {
                    var kalori = _db.ListeBesinler
                   .Include(x => x.Besin)
                   .Where(x => x.ListeId == item.ListeId)
                   .Sum(x => x.Besin.Kalori);
                    lboxGecmisListeler.Items.Add(item.Liste);
                    lblKaloriler.Text += $"{kalori:n2}\r\n";

                    gunlukTopKalori += kalori;
                }
                lblGunlukTopKalori.Text = gunlukTopKalori.ToString("n2");
            }

        }

        private void dtpTarihSec_ValueChanged(object sender, EventArgs e)
        {
            double gunlukTopKalori = 0;
            lboxListeIcerik.Items.Clear();
            lblGunlukTopKalori.Text = "0";
            lblKaloriler.Text = "";

            liste = _db.BitenListeler
                  .Include(x => x.Kullanici)
                  .Include(x => x.Liste)
                  .Where(x => x.KullaniciId == GirenKullanici.Id && x.BitisTarihi.Day == dtpTarihSec.Value.Day).ToList();

            if (liste.Count == 0)
            {
                lboxGecmisListeler.Items.Clear();
                return;
            }

            if (liste.Count > 0)
            {
                foreach (var item in liste)
                {
                    var kalori = _db.ListeBesinler
                   .Include(x => x.Besin)
                   .Where(x => x.ListeId == item.ListeId)
                   .Sum(x => x.Besin.Kalori);
                    lboxGecmisListeler.Items.Add(item.Liste);
                    lblKaloriler.Text += $"{kalori:n2}\r\n";

                    gunlukTopKalori += kalori;
                }
                lblGunlukTopKalori.Text = gunlukTopKalori.ToString("n2");
            }
        }

        private void lboxGecmisListeler_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lboxGecmisListeler.SelectedIndex == -1) return;

                lboxListeIcerik.Items.Clear();

                Liste seciliListeAd = (Liste)lboxGecmisListeler.SelectedItem;

                Liste seciliListe = _db.Listeler.FirstOrDefault(x => x.Id == seciliListeAd.Id);

                var besinler = _db.ListeBesinler
                    .Include(x => x.Liste)
                    .Include(x => x.Besin)
                    .Where(x => x.ListeId == seciliListe.Id).ToList();

                foreach (var item in besinler)
                    lboxListeIcerik.Items.Add(item.Besin.Ad);
            }

            catch (Exception)
            {
                MessageBox.Show("Hatalı işlem");
            }
        }
    }
}
