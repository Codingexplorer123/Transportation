using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public DbSet<Nakliye>Nakliyeler { get; set; }
    }
}
