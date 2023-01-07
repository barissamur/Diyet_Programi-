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
            if (Cinsiyet == "Erkek")
                return 495 / (1.0324 - 0.19077 * Math.Log10(BelCevresi - BoyunCevresi) + 0.15456 * Math.Log10(Boy)) - 450;

            else
                return 495 / (1.29579 - 0.35004 * Math.Log10(BelCevresi + KalcaCevresi - BoyunCevresi) + 0.22100 * Math.Log10(Boy)) - 450;
        }

        public string VucutKitleEndeksi()
        {
            double vke = Kilo / Math.Pow(Boy, 2);

            if (vke < 18.9)
                return "Zayıf";

            else if (vke < 24.9)
                return "Normal";

            else if (vke < 29.9)
                return "Şişman";

            else
                return "Obez";
        }
        public int Yas()
        {
            return DateTime.Now.Year - DogumTarihi.Year;
        }
    }
}
