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
    public partial class YemekCesidiForm : Form
    {
        private readonly DiyetDbContext _db;

        public YemekCesidiForm(DiyetDbContext db)
        {
            InitializeComponent();
            _db=db;

            dgvEnCokBesin.DataSource = _db.Besinler
                .Select(x => new
                {
                    x.Id,
                    x.Ad,
                    x.Kalori,
                    Kategori = x.BesinKategori.Ad,
                    x.Adet
                })
                .OrderByDescending(x => x.Adet)
                .ToList();

            lblEnCokBesin.Text = "Kullanıcılar Arasında En Çok Tercih Edilen Ürün : ";
            lblEnCokBesin.Text += dgvEnCokBesin.Rows[0].Cells[1].Value;

            lblIkinciUrun.Text = "Kullanıcılar Arasında En Çok Tercih Edilen İkinci Ürün : ";
            lblIkinciUrun.Text += dgvEnCokBesin.Rows[1].Cells[1].Value;

            lblUcuncuUrun.Text = "Kullanıcılar Arasında En Çok Tercih Edilen Üçüncü Ürün : ";
            lblUcuncuUrun.Text += dgvEnCokBesin.Rows[2].Cells[1].Value;
        }
    }
}
