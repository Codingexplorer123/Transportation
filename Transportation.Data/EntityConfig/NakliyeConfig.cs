using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using TransportationEntity;

namespace Transportation.Data.EntityConfig
{
    public class NakliyeConfig : IEntityTypeConfiguration<Nakliye>
    {
        public void Configure(EntityTypeBuilder<Nakliye> builder)
        {
            
            builder.Property(p => p.MusteriDegerlendirmeleri).HasMaxLength(200);
            builder.Property(p => p.Aciklama).HasMaxLength(200);
            builder     
                        .HasMany(e => e.Araclar)
                        .WithOne(e => e.Nakliye)
                        .HasForeignKey(e => e.AracId)
                        .HasPrincipalKey(e => e.NakliyeId);


        }
      
        
    }
}
