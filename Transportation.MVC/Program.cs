using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileSystemGlobbing.Internal.Patterns;
using Transportation.Data.Context;
using Transportation.Data.DummyData;
using Transportation.WebApi.Extensions;

namespace Transportation.MVC
{
    public class Program
    {
        public static void Main(string[] args)
        {


            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllersWithViews();
            // MVC i icin gereken Kutuphanede hazir bulunan Serviceleri cagiriyor.

            builder.Services.AddTransient<DataGeneratorArac>();
            // https://learn.microsoft.com/en-us/ef/core/dbcontext-configuration/ burada database e serviceleri kullanarak nasil erisildigi detayli anlatiliyor
            builder.Services.AddDbContext<TransportationDbContext>
                (options => options.UseSqlServer(builder.Configuration.GetConnectionString("Transportation")));

            //EF Core  u ConfigureService metodu olan AddDbContext ile appsettings.json database ayarlarini kullanarak database imize erismesini sagladik. 

            builder.Services.AddTransportationServisleri();

            // Extension klasorunde bulunan servicelerimizi kaydettik.


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // burada development asamasindayken alacagimiz hatalari detaylari ile programi calistirdigimizda gostermesini istedik.
            }

            app.UseStaticFiles();
            // Middleware wwroot klasorunu web e actik. Ozellikle bootstrap kutuphanesini kullanacagiz uygulamamizda

            app.UseRouting();
            // Client tarafindan gelen http requestlerin icerisindeki Urlde cozumleme yapar. Ona Gore ilgili controller in gerekli action metoduna istek duser.
            app.UseAuthorization();
            // Authorization yapmadik henuz yapacagiz. Authentication yaptiktan sonra

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            // Buradaki default Routeda eger http requestte controller belirtilmemisse ilk olarak Home Controller duseceginiz vs. belirtiyor.
            app.Run();
            // Uygulamayi ayaga kaldirma metodu


        }
    }
}