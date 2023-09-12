using Microsoft.AspNetCore.Identity;
using Transportation.Business.Abstract;
using Transportation.Business.Concrete;
using Transportation.Data.Repository.Abstract;
using Transportation.Data.Repository.Concrete;

namespace Transportation.WebApi.Extensions
{
    public static class AddTransportationServis
    {
        // Burada dosya acmamin nedini tum servisleri program cs yazinca kod kalabaligi oluyor, okunakli olmadigi icin buraya tum servisleri tanimlayip
        // en son servisleri program.cs dosyasina gondericem
        public static IServiceCollection AddTransportationServisleri(this IServiceCollection services)
        {
           // services.AddScoped<IUserRepository,UserRepository>();
            services.AddScoped<IUserManager,UserManager>();         // User sinifindaki Repository pattern ve business katmani servisleri eklendi.
            
           // services.AddScoped<IRezervasyonRepository,RezervasyonRepository>();
            services.AddScoped<IRezervasyonManager,RezervasyonManager>();        // Rezervasyon sinifindaki Repository pattern ve business katmani servisleri eklendi.

           // services.AddScoped<INakliyeRepository, NakliyeRepository>();
            services.AddScoped<INakliyeManager, NakliyeManager>();             // Nakliye sinifindaki Repository pattern ve business katmani servisleri eklendi.

            //services.AddScoped<IAracRepository, AracRepository>();
            services.AddScoped<IAracManager,AracManager>();             // Arac sinifindaki Repository pattern ve business katmani servisleri eklendi.

           // services.AddScoped<IRoleRepository, RoleRepository>();
            services.AddScoped<IRoleManager, RoleManager>();          // Role sinifindaki Repository pattern ve business katmani servisleri eklendi.


            return services;

        }
    }
}
