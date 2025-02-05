// using WineCellarAPI.Data;
// using WineCellarAPI.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

// namespace WineCellarAPI.Services;
public class WineCellarService
{
    //on init get context
    private readonly WineCellarContext _context;
    public WineCellarService(WineCellarContext context)
    {
        _context = context;
    }

    //CRUD Mwthods here:
    public IEnumerable<Wine> GetAllWines()
    {
        return _context.Wines.AsNoTracking().ToList();
    }

    public Wine? GetWineById(int id)
    {
        return _context.Wines
        .Include(p => p.Aromas)
        .Include(p => p.GrapeVarieties)
        .AsNoTracking()
        .SingleOrDefault(p => p.Id == id);
    }

    public void CreateWine(Wine wine)
    {
        if (wine != null)
        {
            _context.Wines.Add(wine);
            _context.SaveChanges();
        }
    }


    //Delete Wine.
    public void DeleteWineById(int id)
    {
        var wineToDelete = _context.Wines.SingleOrDefault(w => w.Id == id);
        if (wineToDelete != null)
        {
            _context.Wines.Remove(wineToDelete);
            _context.SaveChanges();
        }

    }

    //Update, what?
    public void UpdateWine(Wine wine)
    {
        var wineToReplace = _context.Wines.SingleOrDefault(w => w.Id == wine.Id);

    }
}