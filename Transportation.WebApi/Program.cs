using Microsoft.EntityFrameworkCore;
using Transportation.Data.Context;
using Transportation.Data.DummyData;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<DataGeneratorArac>();
// https://learn.microsoft.com/en-us/ef/core/dbcontext-configuration/ burada database e serviceleri kullanarak nasil erisildigi detayli anlatiliyor
builder.Services.AddDbContext<TransportationDbContext>
    (options => options.UseSqlServer(builder.Configuration.GetConnectionString("Transportation")));

//EF Core  u ConfigureService metodu olan AddDbContext ile appsettings.json database ayarlarini kullanarak database imize erismesini sagladik. 
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
