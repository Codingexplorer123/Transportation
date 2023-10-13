using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransportationEntity;

namespace Transportation.Data.EntityConfig
{
    public class AracConfig : IEntityTypeConfiguration<Arac>
    {
        public void Configure(EntityTypeBuilder<Arac> builder)
        {
            builder.Property(p => p.AracTipi).IsRequired();
            builder.Property(p=> p.AracSoforuIsim).IsRequired();
            builder.Property(p=> p.AracSoforuSoyisim).IsRequired();
            builder.Property(p=> p.AracPlakaNo).IsRequired();
            builder.HasIndex(p=> p.AracPlakaNo).IsUnique();
            builder.HasIndex(p=> p.AracSoforuTelNo).IsUnique();
            builder.Property(p=>p.AracSoforuTelNo).IsRequired();
            builder.Property(p=>p.FirmaTelNo).IsRequired();

            builder.HasOne<Nakliye>(e => e.Nakliye).WithMany(e => e.Araclar).HasForeignKey(e => e.AracId).HasPrincipalKey(e => e.NakliyeId);
                        
                        

        }
       
    }
}
