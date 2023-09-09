using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Transportation.Data.DummyData;
using TransportationEntity;

namespace Transportation.Data.Context
{
    public class TransportationDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer
            ("Server =(localdb)\\MSSqlLocalDb; Database=Transportation; Trusted_Connection=True;TrustServerCertificate=true");
            // Lokalimdeki SQL Server Baglantim database calismasi icin connectionstring ifadesini degistiriniz.
        }
        public TransportationDbContext()
        {
            
        }
        public TransportationDbContext(DbContextOptions<TransportationDbContext> options):base(options)
        {
            
        }

        public DbSet<Nakliye>Nakliyeler { get; set; }
        public DbSet<Arac>Araclar { get; set; }
        public DbSet<Rezervasyon> Rezervasyonlar { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            //Burasi Calisan Assembly icersinde ITypeEntityConfig interface'inden kalitim almis ne kadar class varsa 
            // onun icerisindeki Configure metodunu cagirir.
            modelBuilder.Entity<Arac>().HasData(DataGenerator.Araclar);
        }
    }
}
