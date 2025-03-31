using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

public class WeatherController : Controller
{
    private readonly WeatherContext _context;

    public WeatherController(WeatherContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        return View(await _context.Weathers.ToListAsync());
    }
}
