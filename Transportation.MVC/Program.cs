using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileSystemGlobbing.Internal.Patterns;
using Transportation.Data.Context;
using Transportation.Data.DummyData;
using Transportation.MVC.AutoMapperProfile;
using Transportation.MVC.Models;
using Transportation.WebApi.Extensions;
using TransportationEntity;

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
builder.Services.AddAutoMapper(typeof(TransportationProfile));
// Extension klasorunde bulunan servicelerimizi kaydettik.
//Identity Serviselerini Eklenmesi
builder.Services.AddIdentity<MyUser, IdentityRole>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<TransportationDbContext>();

//Identity'yi Configure Etme
builder.Services.Configure<IdentityOptions>(options =>
{
	// Password settings.
	options.Password.RequireDigit = false;
	options.Password.RequireLowercase = false;
	options.Password.RequireNonAlphanumeric = false;
	options.Password.RequireUppercase = false;
	options.Password.RequiredLength = 3;
	options.Password.RequiredUniqueChars = 1;

	// Lockout settings.
	options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
	options.Lockout.MaxFailedAccessAttempts = 5;
	options.Lockout.AllowedForNewUsers = true;

	// User settings.

	options.User.RequireUniqueEmail = true;
	options.SignIn.RequireConfirmedEmail = false;
	options.SignIn.RequireConfirmedPhoneNumber = false;
});

//Cookie Ayarlari
builder.Services.ConfigureApplicationCookie(options =>
{
	// Cookie settings
	options.Cookie.HttpOnly = true;
	options.ExpireTimeSpan = TimeSpan.FromMinutes(5);

	options.LoginPath = "/Login/Index";
	options.AccessDeniedPath = "/Login/AccessDenied";
	options.LogoutPath = "/Login/Logout";
	options.SlidingExpiration = true;
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    //app.UseExceptionHandler("/Home/Error");
	app.UseDeveloperExceptionPage();
    // burada development asamasindayken alacagimiz hatalari detaylari ile programi calistirdigimizda gostermesini istedik.
}

app.UseStaticFiles();
// Middleware wwroot klasorunu web e actik. Ozellikle bootstrap kutuphanesini kullanacagiz uygulamamizda

app.UseRouting();
// Client tarafindan gelen http requestlerin icerisindeki Urlde cozumleme yapar. Ona Gore ilgili controller in gerekli action metoduna istek duser.
app.UseAuthentication();
app.UseAuthorization();
// Authorization yapmadik henuz yapacagiz. Authentication yaptiktan sonra

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

// Buradaki default Routeda eger http requestte controller belirtilmemisse ilk olarak Home Controller duseceginiz vs. belirtiyor.
app.Run();
// Uygulamayi ayaga kaldirma metodu