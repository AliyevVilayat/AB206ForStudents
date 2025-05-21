using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ScholarProject.BL.Services;
using ScholarProject.DAL.Contexts;
using ScholarProject.DAL.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

string connectionStr = builder.Configuration.GetConnectionString("Asus");
builder.Services.AddDbContext<AppDbContext>(opt => opt.UseSqlServer(connectionStr));

builder.Services.AddIdentity<AppUser, AppRole>()
                .AddEntityFrameworkStores<AppDbContext>()
                .AddDefaultTokenProviders();


builder.Services.AddScoped<AccountService>();


var app = builder.Build();

app.UseAuthentication();
app.UseAuthorization();


app.UseStaticFiles();

app.MapControllerRoute(

    name: "Default",
    pattern: "{Controller=Home}/{Action=Index}"

    );

app.Run();
