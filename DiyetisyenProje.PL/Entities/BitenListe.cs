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
        public int ListeId { get; set; }
        public Liste Liste { get; set; }
        public DateTime BitisTarihi { get; set; }

        public override string ToString()
        {
            return Liste.ListeAdi + " " + $"{Liste.Besinler.Sum(x => x.Kalori):n2}";
        }
    }
}
