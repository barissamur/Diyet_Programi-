using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetisyenProje.PL.Entities
{
    public class Besin
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public double Kalori { get; set; }
        public BesinKategori BesinKategori { get; set; }
        public int BesinKategoriId { get; set; }
        public int Adet { get; set; }
        public List<Liste> Listeler { get; set; }

        public override string ToString()
        {
            return $"{Ad} {Kalori}";
        }
    }
}
