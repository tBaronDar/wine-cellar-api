using WineCellarAPI.Models;
using WineCellarAPI.Services;

namespace WineCellarAPI.Data;

public static class DbInitializer
{

    public static void Initialize(WineCellarContext context)
    {

        if (context.Wines.Any() && context.Aromas.Any())
        {
            return;
        }
        //if no tables exist
        //add logic
    }
}