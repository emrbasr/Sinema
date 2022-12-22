using Microsoft.EntityFrameworkCore;
using Sinema.Entities.Concrete;
using System.Reflection;

namespace Sinema.Dal.Context
{
    public class SqlDbContext : DbContext
    {
        public DbSet<Film> Filmler { get; set; }
        public DbSet<Kategori> Kategoriler { get; set; }
        public DbSet<Hafta> Haftalar { get; set; }
        public DbSet<Salon> Salonlar { get; set; }
        public DbSet<Seans> Seanslar { get; set; }
        public DbSet<Gosterim> Gosterimler { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Sinemam;Trusted_Connection=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
