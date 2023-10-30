using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Siniflar
{
        public class KargoTakipOtomasyonuContext : DbContext
        {
        public DbSet<Kargo> Kargos { get; set; }
        public DbSet<Musteri> Musteris { get; set; }
        public DbSet<Personel> Personels { get; set; }
    }
}
