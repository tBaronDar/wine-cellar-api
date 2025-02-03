using WineCellarAPI.Data;
using WineCellarAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace WineCellarAPI.Services;
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
}