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
    public class RezervasyonConfig : IEntityTypeConfiguration<Rezervasyon>
    {
        public void Configure(EntityTypeBuilder<Rezervasyon> builder)
        {
            builder.Property(p=>p.NakliyeFirmasiEmail).IsRequired();
            builder.HasIndex(p=>p.NakliyeFirmasiEmail).IsUnique();

            builder.HasOne<Nakliye>(e => e.Nakliye).WithOne(e => e.Rezervasyon).HasForeignKey<Nakliye>(e => e.NakliyeId);
                        
        }

        
    }
}
