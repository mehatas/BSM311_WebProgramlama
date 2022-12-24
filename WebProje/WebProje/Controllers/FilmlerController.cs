using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebProje.Data;

namespace WebProje.Controllers
{
    public class FilmlerController : Controller
    {
        private readonly Veritabani _context;

        public FilmlerController(Veritabani context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var tumFilmler = await _context.Filmler.ToListAsync();
            return View();
        }
    }
}
