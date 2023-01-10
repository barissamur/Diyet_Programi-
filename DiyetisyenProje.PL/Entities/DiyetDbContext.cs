using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetisyenProje.PL.Entities
{
    public class DiyetDbContext : DbContext
    {
        public DbSet<Besin> Besinler { get; set; }
        public DbSet<Kullanici> Kullanicilar { get; set; }
        public DbSet<Admin> Adminler { get; set; }
        public DbSet<Liste> Listeler { get; set; }
        public DbSet<BitenListe> BitenListeler { get; set; }
        public DbSet<BesinKategori> BesinKategoriler { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.; database=DiyetisyenProjeDb; integrated security=true");
        }
    }
}
