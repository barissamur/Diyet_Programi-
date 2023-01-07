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
    public partial class ListelerimForm : Form
    {
        private readonly DiyetDbContext _db;
        private readonly string _girenKullanici;
        Kullanici GirenKullanici;
        Liste seciliListe;

        public ListelerimForm(DiyetDbContext db, string girenKullanici)
        {
            InitializeComponent();
            _db=db;
            _girenKullanici=girenKullanici;
            GirenKullanici = db.Kullanicilar.FirstOrDefault(x => x.KullaniciAdi.Contains(girenKullanici));

            bool listeler = _db.Listeler.Any(x => x.KullaniciId == GirenKullanici.Id);

            if (listeler)
                ListeleriGoster();

            if (_db.Listeler.Find(GirenKullanici.ListeId) != null)
            {
                lblSeciliListe.Text =_db.Listeler.Find(GirenKullanici.ListeId).ListeAdi;
            }
        }


        private void lboxListelerim_SelectedIndexChanged(object sender, EventArgs e)
        {
            lboxListeIcerik.Items.Clear();
            if (lboxListelerim.SelectedIndex != -1)
            {
                Liste listeAdi = (Liste)lboxListelerim.SelectedItem;


                seciliListe = _db.Listeler
                    .FirstOrDefault(x => x.Id == listeAdi.Id);

                var listeBesinler = _db.ListeBesinler
                    .Include(x => x.Besin)
                    .Include(x => x.Liste)
                    .Where(x => x.ListeId == seciliListe.Id)
                    .ToList();

                foreach (var item in listeBesinler)
                    lboxListeIcerik.Items.Add(item.Besin.Ad);

                lblSeciliListe.Text =_db.Listeler.FirstOrDefault(x => x.Id == seciliListe.Id).ListeAdi;
            }
        }

        private void btnListeSec_Click(object sender, EventArgs e)
        {
            if (lboxListelerim.SelectedIndex == -1) return;

            GirenKullanici.ListeId = seciliListe.Id;
            _db.SaveChanges();

            MessageBox.Show($"{seciliListe.ListeAdi} listesi sıradaki öğününüz olarak belirlendi");


            if (GirenKullanici.ListeId > 0)
                lblSeciliListe.Text =_db.Listeler.Find(GirenKullanici.ListeId).ListeAdi;

            Close();
        }

        private void btnListeSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (seciliListe == null) return;
                seciliListe.KullaniciId = 0;

                if (seciliListe.Id == GirenKullanici.ListeId)
                    GirenKullanici.ListeId = 0;

                _db.SaveChanges();
                lblSeciliListe.Text = "Seçili liste yok";
                ListeleriGoster();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hatalı işlem");
            }
        }

        #region Metotlar
        private void ListeleriGoster()
        {
            lboxListelerim.DataSource = null;
            var listeler = _db.Listeler
                .Where(x => x.KullaniciId == GirenKullanici.Id)
                .ToList();

            lboxListelerim.DataSource= listeler;
        }
        #endregion
    }
}
