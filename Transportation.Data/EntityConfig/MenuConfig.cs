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
    public class MenuConfig : IEntityTypeConfiguration<Menu>
    {
        public void Configure(EntityTypeBuilder<Menu> builder)
        {
           builder.HasKey(x => x.Id);
            builder.Property(p=>p.Area).HasMaxLength(50);
            builder.Property(p => p.Controller).HasMaxLength(50);
            builder.Property(p => p.Action).HasMaxLength(50);
            builder.Property(p => p.Class).HasMaxLength(500);
            builder.Property(p => p.Icon).HasMaxLength(500);
            builder.Property(p => p.MenuAdi).HasMaxLength(100);





        }
    }
}
