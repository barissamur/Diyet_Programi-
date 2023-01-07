using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetisyenProje.PL.Entities
{
    public class Liste
    {
        public int Id { get; set; }
        public string ListeAdi { get; set; }
        public int KullaniciId { get; set; }
        public override string ToString()
        {
            return ListeAdi;
        }
    }
}
