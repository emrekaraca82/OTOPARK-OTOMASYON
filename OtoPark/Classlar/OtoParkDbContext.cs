using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoPark.Classlar
{
    class OtoParkDbContext:DbContext
    {
        public DbSet<Marka>Tbl_Marka { get; set; }
        public DbSet<Seri> Tbl_Seri { get; set; }  
        public DbSet<AracParkYerleri> Tbl_AracParkYerleri { get; set; }
        public DbSet<Musteri> Tbl_Musteri { get; set; }
        public DbSet<AracParkBilgileri> Tbl_AracParkBilgileri { get; set; }
        public DbSet<Satis> Tbl_Satis { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }

    }
}
