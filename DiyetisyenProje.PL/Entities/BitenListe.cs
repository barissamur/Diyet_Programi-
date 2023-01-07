using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetisyenProje.PL.Entities
{
    public class BitenListe
    {
        public int Id { get; set; }
        public int KullaniciId { get; set; }
        public Kullanici Kullanici { get; set; }
        public int ListeId { get; set; }
        public Liste Liste { get; set; }
        public DateTime BitisTarihi { get; set; }
    }
}
