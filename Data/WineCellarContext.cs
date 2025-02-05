using Microsoft.EntityFrameworkCore;
using WineCellarAPI.Models;

namespace WineCellarAPI.Data;
public class WineCellarContext : DbContext
{
    public WineCellarContext(DbContextOptions<WineCellarContext> options)
        : base(options)
    {
    }

    //these are the data models(tables) EF will create
    public DbSet<Wine> Wines => Set<Wine>();
    public DbSet<Aroma> Aromas => Set<Aroma>();
    public DbSet<GrapeVariety> GrapeVarieties => Set<GrapeVariety>();

}