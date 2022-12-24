using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebProje.Data;

namespace WebProje.Controllers
{
    public class YapimcilarController : Controller
    {
        private readonly Veritabani _context;

        public YapimcilarController(Veritabani context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var tumYapimcilar = await _context.Yapimcilar.ToListAsync();
            return View();
        }
    }
}
