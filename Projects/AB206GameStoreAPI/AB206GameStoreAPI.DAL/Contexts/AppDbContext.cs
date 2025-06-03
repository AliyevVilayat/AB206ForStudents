using AB206GameStoreAPI.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace AB206GameStoreAPI.DAL.Contexts;

public class AppDbContext : DbContext
{
    public DbSet<TrendingGame> TrendingGames { get; set; }
    public AppDbContext(DbContextOptions opt) : base(opt)
    {

    }
}
