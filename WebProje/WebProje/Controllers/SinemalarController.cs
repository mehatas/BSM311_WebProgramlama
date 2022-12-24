using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebProje.Data;

namespace WebProje.Controllers
{
    public class SinemalarController : Controller
    {
        private readonly Veritabani _context;

        public SinemalarController(Veritabani context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var tumSinemalar = await _context.Sinemalar.ToListAsync();
            return View();
        }
    }
}
