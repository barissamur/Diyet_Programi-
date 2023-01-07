using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace DiyetisyenProje.PL.Entities
{
    public class Kullanici
    {
        public int Id { get; set; }
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
        public string Cinsiyet { get; set; }
        public double Kilo { get; set; }
        public DateTime DogumTarihi { get; set; }
        public double BoyunCevresi { get; set; }
        public double BelCevresi { get; set; }
        public double KalcaCevresi { get; set; }
        public int ListeId { get; set; }
        public double Boy { get; set; }

        public double YagOrani()
        {
            return (BoyunCevresi + BelCevresi + KalcaCevresi) / (Boy / Kilo) / 8;
        }

        public string VucutKitleEndeksi()
        {
            double vke = Kilo / Math.Pow((Boy / 100), 2);

            if (vke < 18.9)
                return "Zayıf";

            else if (vke < 27)
                return "Normal";

            else if (vke < 29.9)
                return "Şişman";

            else if (vke < 35.0)
                return "Obez";

            else
                return " Aşırı Obez";
        }
        public int Yas()
        {
            return DateTime.Now.Year - DogumTarihi.Year;
        }
    }
}
