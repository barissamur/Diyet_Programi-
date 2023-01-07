using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetisyenProje.PL.Entities
{
    public class ListeBesin
    {
        public int Id { get; set; }
        public int ListeId { get; set; }
        public Liste? Liste { get; set; }
        public int BesinId { get; set; }
        public Besin Besin { get; set; }
    }
}
