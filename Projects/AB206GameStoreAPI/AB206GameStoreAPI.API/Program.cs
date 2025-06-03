using AB206GameStoreAPI.BL.Service.Concretes;
using AB206GameStoreAPI.BL.Service.Interfaces;
using AB206GameStoreAPI.DAL.Contexts;
using AB206GameStoreAPI.DAL.Entities;
using AB206GameStoreAPI.DAL.Repositories.Concretes;
using AB206GameStoreAPI.DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


//Add Context
builder.Services.AddDbContext<AppDbContext>(opt =>
{
    opt.UseSqlServer(builder.Configuration.GetConnectionString("Asus"));
});


//Add Services
builder.Services.AddScoped<ITrendingGameService, TrendingGameService>();


//Add Repositories
builder.Services.AddScoped<IRepository<TrendingGame>, Repository<TrendingGame>>();


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
