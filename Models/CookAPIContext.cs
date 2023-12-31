using Microsoft.EntityFrameworkCore;

namespace CookAPI.Models;

public class CookAPIContext : DbContext
{
    public CookAPIContext(DbContextOptions<CookAPIContext> options)
        : base(options)
    {
    }

    public DbSet<Recipe> Recipes { get; set; } = null!;
}