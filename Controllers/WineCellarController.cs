using Microsoft.AspNetCore.Mvc;
// using WineCellarAPI.Models;
// using WineCellarAPI.Services;

// namespace WineCellarAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class WineCellarController : ControllerBase
{
    WineCellarService _service;

    public WineCellarController(WineCellarService service)
    {
        _service = service;
    }

    [HttpGet]
    public IEnumerable<Wine> GetAllWines()
    {
        return _service.GetAllWines();
    }

    [HttpGet("{id}")]
    public ActionResult<Wine> GetWineById(int id)
    {
        var wine = _service.GetWineById(id);
        if (wine is null)
        {
            return NotFound();
        }
        else
        {
            return wine;
        }
    }

    [HttpPost("{wine}")]
    public ActionResult<Wine> CreateNewWine(Wine wine)
    {
        _service.CreateWine(wine);
        return wine;
    }

    [HttpDelete("{id}")]
    public ActionResult<int> DeleteWine(int id)
    {
        _service.DeleteWineById(id);
        return id;
    }
}