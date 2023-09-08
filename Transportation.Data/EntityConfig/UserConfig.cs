using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransportationEntity;

namespace Transportation.Data.EntityConfig
{
    public class UserConfig: IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User>builder)
        // Burdaki metod ile DbContext icerisindeki OnModelCreating Metodumuz sismesin diye entity configurasyonlari buraya
        //tanimlanmistir. Detayli bilgi icin https://learn.microsoft.com/en-us/ef/core/modeling/ sayfasindaki Grouping Configuration bakabilirsiniz.
        {
            builder.Property(p=>p.Name).IsRequired();           //Name Property Configurasyonu
            builder.Property(p => p.Name).HasMaxLength(20);
            
            builder.Property(p => p.LastName).IsRequired();      // LastName Property Configurasyonu
            builder.Property(p => p.LastName).HasMaxLength(30);

            

            builder.Property(p => p.Email).IsRequired();          // Email Property Configurasyonu
            builder.Property(p => p.Email).IsRequired();
            builder.HasIndex(p => p.Email).IsUnique();
            
            builder.HasIndex(p=>p.PhoneNumber).IsUnique();

            builder.Property(p => p.TCNo).HasMaxLength(11);

            //Test Asamasinda kullanilmasi icin sistem ayaga kaldirilirken data seeding ile bir kullanici olusturuyorum
            builder.HasData(
                new User
                {
                    UserId = 1,
                    Name = "Berk",
                    LastName = "Ozgurcan",
                    Email = "berk@gmail.com",
                    PhoneNumber = "5351111111",
                    Adress = "Istanbul",
                    DogumTarihi = new DateTime(1955,11,2),
                    Password="1234",
                    TCNo=11111111111,


                });
            


        }
    }
}
