using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransportationEntity;

namespace Transportation.Data.EntityConfig
{
    public class RoleConfig
    {
        public  void Configure(EntityTypeBuilder<Role> builder) 
        {
            builder.HasIndex(p=>p.RoleName).IsUnique();
            builder.HasData(new Role { RoleId = 1, RoleName = "Admin" });
        }
    }
}
