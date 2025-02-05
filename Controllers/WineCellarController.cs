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

    [HttpGet("{Id}")]
    public ActionResult<Wine> GetWineById(int Id)
    {
        var wine = _service.GetWineById(Id);
        if (wine is null)
        {
            return NotFound();
        }
        else
        {
            return wine;
        }
    }

}