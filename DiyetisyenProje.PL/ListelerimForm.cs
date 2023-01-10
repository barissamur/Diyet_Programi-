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
            GirenKullanici = db.Kullanicilar.FirstOrDefault(x => x.KullaniciAdi == girenKullanici);


            ListeleriGoster();

            if (_db.Listeler.Find(GirenKullanici.ListeId) != null)
                lblSeciliListe.Text =_db.Listeler.Find(GirenKullanici.ListeId).ListeAdi;

            lboxListeIcerik.DataSource = null;
            lboxListelerim.SelectedIndex = -1;
        }


        private void lboxListelerim_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lboxListelerim.SelectedIndex != -1)
            {
                seciliListe = (Liste)lboxListelerim.SelectedItem;

                _db.Entry(seciliListe).Collection(s => s.Besinler).Load();
                lboxListeIcerik.DataSource = seciliListe.Besinler.ToList();

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

                seciliListe.silindiMi = true;

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
                .Where(x => x.KullaniciId == GirenKullanici.Id && x.silindiMi == false)
                .ToList();

            if (listeler == null) return;
            lboxListelerim.DataSource= listeler;
            lboxListeIcerik.DataSource = null;
        }
        #endregion
    }
}
