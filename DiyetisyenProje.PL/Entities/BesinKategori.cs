using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetisyenProje.PL.Entities
{
    public class BesinKategori
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public List<Besin> Besinler { get; set; }
    }
}
