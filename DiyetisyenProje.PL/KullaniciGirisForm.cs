using DiyetisyenProje.PL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiyetisyenProje.PL
{
    public partial class KullaniciGirisForm : Form
    {
        private readonly DiyetDbContext _db;
        private readonly string _girenKullanici;
        Kullanici GirenKullanici;
        double topKalori = 0;
        List<ListeBesin> lstBesn;
        Liste listeAd;
        Liste liste;
        public KullaniciGirisForm(DiyetDbContext db, string girenKullanici)
        {
            InitializeComponent();
            _db=db;
            lblTopKalori.Text = "Toplam Kalor : ";
            _girenKullanici=girenKullanici;

            GirenKullanici = db.Kullanicilar.FirstOrDefault(x => x.KullaniciAdi.Contains(girenKullanici));

            lblAdSoyad.Text = " "  + GirenKullanici.Ad + " " + GirenKullanici.Soyad;
            lblCinsiyet.Text +=  " "  +  GirenKullanici.Cinsiyet;
            lblYas.Text += " "  +  GirenKullanici.Yas();
            lblBoy.Text += " "  +  GirenKullanici.Boy.ToString("n2");
            lblKilo.Text += " "  +  GirenKullanici.Kilo;
            lblVKE.Text += " "  +  GirenKullanici.VucutKitleEndeksi();
            lblYagOrani.Text += " "  +  GirenKullanici.YagOrani().ToString("n2");
            lblTarih.Text = DateTime.Now.ToString("dd.MM.yyyy");

            if (GirenKullanici.ListeId > 0)
            {
                listeAd = _db.Listeler.Find(GirenKullanici.ListeId);

                lstBesn = _db.ListeBesinler
                    .Include(x => x.Besin)
                    .Include(x => x.Liste)
                    .Where(x => x.ListeId == listeAd.Id)
                    .ToList();

                foreach (var item in lstBesn)
                {
                    lboxListem.Items.Add(item.Besin.Ad);
                }

                listeAd = _db.Listeler.Find(GirenKullanici.ListeId);
                lblListeAd.Text = listeAd?.ListeAdi.ToString();

                topKalori = lstBesn.Sum(x => x.Besin.Kalori);
                lblTopKalori.Text += topKalori.ToString("n2");
            }
        }

        private void llListelerim_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ListelerimForm listelerimForm = new ListelerimForm(_db, _girenKullanici);
            listelerimForm.ShowDialog();

            if (listelerimForm.DialogResult == DialogResult.Cancel)
            {
                lblTopKalori.Text = "Toplam Kalor : ";
                lboxListem.Items.Clear();
                lblListeAd.Text = "Liste Adı : ";
                if (GirenKullanici.ListeId != 0)
                {
                    listeAd = _db.Listeler.Find(GirenKullanici.ListeId);
                    lblListeAd.Text += listeAd?.ListeAdi.ToString();

                    liste = _db.Listeler.Find(GirenKullanici.ListeId);

                    lstBesn = _db.ListeBesinler
                       .Include(x => x.Besin)
                       .Include(x => x.Liste)
                       .Where(x => x.ListeId == liste.Id)
                       .ToList();

                    foreach (var item in lstBesn)
                        lboxListem.Items.Add(item.Besin.Ad);

                    topKalori = lstBesn.Sum(x => x.Besin.Kalori);
                    lblTopKalori.Text += topKalori.ToString("n2");
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            BesinListeForm besinListeForm = new BesinListeForm(_db, _girenKullanici);
            besinListeForm.ShowDialog();
        }

        private void btnListeBitir_Click(object sender, EventArgs e)
        {
            if (GirenKullanici.ListeId == 0) return;

            foreach (var item in lboxListem.Items)
            {
                Besin besin = _db.Besinler.FirstOrDefault(x => x.Ad == item.ToString());
                besin.Adet++;
            }

            BitenListe bitenListe = new BitenListe()
            {
                KullaniciId = GirenKullanici.Id,
                ListeId = listeAd.Id,
                BitisTarihi = DateTime.Now,
            };
            GirenKullanici.ListeId = 0;
            _db.BitenListeler.Add(bitenListe);
            _db.SaveChanges();

            lboxListem.Items.Clear();
            lblListeAd.Text = "";
            lblTopKalori.Text = "Toplam Kalor : ";
        }

        private void llGunSonuRaporu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GunSonuRaporuForm gunSonuRaporuForm = new GunSonuRaporuForm(_db, _girenKullanici);
            gunSonuRaporuForm.ShowDialog();
        }

        private void llYemekCesidi_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            YemekCesidiForm yemekCesidiForm = new YemekCesidiForm(_db);
            yemekCesidiForm.ShowDialog();
        }
    }
}
