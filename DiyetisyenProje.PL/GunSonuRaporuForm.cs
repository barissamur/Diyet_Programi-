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
        List<BitenListe> bitenListeler;
        double gunlukTopKalori = 0;
        BitenListe seciliListe;
        Liste silinenListe;
        public GunSonuRaporuForm(DiyetDbContext db, string girenKullanici)
        {
            InitializeComponent();
            _db=db;
            _girenKullanici=girenKullanici;
            GirenKullanici = db.Kullanicilar.FirstOrDefault(x => x.KullaniciAdi.Contains(girenKullanici));

            bitenListeler = _db.BitenListeler
                  .Include(x => x.Liste)
                  .ThenInclude(x => x.Besinler)
                  .Where(x => x.Liste.KullaniciId == GirenKullanici.Id && x.BitisTarihi.Day == dtpTarihSec.Value.Day)
                  .ToList();

            lboxGecmisListeler.DataSource = bitenListeler;

            seciliListe = (BitenListe)lboxGecmisListeler.SelectedItem;

            if (seciliListe != null)
                silinenListe = _db.Listeler.FirstOrDefault(x => x.Id == seciliListe.ListeId);

            if (bitenListeler.Count > 0)
            {
                var kalori = silinenListe.Besinler.Sum(x => x.Kalori);

                foreach (BitenListe item in bitenListeler)
                {
                    if (item != null)
                        gunlukTopKalori += item.Liste.Besinler.Sum(x => x.Kalori);
                }

                lblGunlukTopKalori.Text = gunlukTopKalori.ToString("n2");
            }
        }

        private void dtpTarihSec_ValueChanged(object sender, EventArgs e)
        {
            double gunlukTopKalori = 0;

            lboxGecmisListeler.DataSource = null;
            lboxListeIcerik.DataSource = null;

            lblGunlukTopKalori.Text = "0";

            bitenListeler = _db.BitenListeler
                  .Include(x => x.Liste)
                  .ThenInclude(x => x.Besinler)
                  .Where(x => x.Liste.KullaniciId == GirenKullanici.Id && x.BitisTarihi.Day == dtpTarihSec.Value.Day)
                  .ToList();


            if (bitenListeler.Count == 0)
                return;

            if (bitenListeler.Count > 0)
            {
                lboxGecmisListeler.DataSource = bitenListeler;
                var kalori = silinenListe.Besinler.Sum(x => x.Kalori);

                foreach (BitenListe item in bitenListeler)
                    gunlukTopKalori += item.Liste.Besinler.Sum(x => x.Kalori);

                lblGunlukTopKalori.Text = gunlukTopKalori.ToString("n2");
            }
        }

        private void lboxGecmisListeler_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lboxGecmisListeler.SelectedIndex == -1) return;

                lboxListeIcerik.DataSource = null;

                seciliListe = (BitenListe)lboxGecmisListeler.SelectedItem;
                silinenListe = _db.Listeler.FirstOrDefault(x => x.Id == seciliListe.ListeId);

                _db.Entry(silinenListe).Collection(x => x.Besinler).Load();
                lboxListeIcerik.DataSource = silinenListe.Besinler.ToList();
            }

            catch (Exception)
            {
                MessageBox.Show("Hatalı işlem");
            }
        }

        private void btnListeGeriYukle_Click(object sender, EventArgs e)
        {
            Liste geriYukle = new Liste()
            {
                ListeAdi = silinenListe.ListeAdi,
                KullaniciId = silinenListe.KullaniciId,
                Besinler = silinenListe.Besinler,
            };

            _db.Listeler.Add(geriYukle);
            _db.SaveChanges();

            MessageBox.Show("Liste geri yüklendi");
        }
    }
}
