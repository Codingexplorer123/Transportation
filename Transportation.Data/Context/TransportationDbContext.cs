using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
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
    public class TransportationDbContext:IdentityDbContext<MyUser>
    {


        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer
            ("Server =.; Database=Transportation; Trusted_Connection=True;TrustServerCertificate=true");
            // Lokalimdeki SQL Server Baglantim database calismasi icin connectionstring ifadesini degistiriniz.
        }
        public TransportationDbContext()
        {
            
        }
        
        public TransportationDbContext(DbContextOptions<TransportationDbContext> options):base(options)
        {
            
        }
        // DbContext deki context ayarlari TransportationDbContext e aktarildi.
        public DbSet<Nakliye>Nakliyeler { get; set; }
        public DbSet<Arac>Araclar { get; set; }
        public DbSet<Rezervasyon> Rezervasyonlar { get; set; }
      

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            //Burasi Calisan Assembly icersinde ITypeEntityConfig interface'inden kalitim almis ne kadar class varsa 
            // onun icerisindeki Configure metodunu cagirir.

            modelBuilder.Entity<Arac>().HasData(DataGeneratorArac.AracListesi(5));
            modelBuilder.Entity<Nakliye>().HasData(DataGeneratorNakliye.NakliyeListesi(5));
            modelBuilder.Entity<Rezervasyon>().HasData(DataGeneratorRezervasyon.RezervasyonListesi(5));
            var UserID = Guid.NewGuid().ToString();

			modelBuilder.Entity<MyUser>().HasData(new MyUser { Id = UserID, UserName = "admin", Email = "admin@qwe.com" });
            var roleID = Guid.NewGuid().ToString();

			modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole { Id=roleID,Name="admin",NormalizedName="ADMIN"});
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>() { RoleId = roleID, UserId = UserID });

		}
	}
}
