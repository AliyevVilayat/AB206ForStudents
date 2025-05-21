using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ScholarProject.DAL.Models;

namespace ScholarProject.DAL.Contexts;

public class AppDbContext : IdentityDbContext<AppUser, AppRole, string>
{

    public DbSet<Course> Courses { get; set; }
    public AppDbContext(DbContextOptions options) : base(options)
    {

    }
}
