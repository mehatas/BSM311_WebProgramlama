using Microsoft.AspNetCore.Mvc;
using WebProje.Data;

namespace WebProje.Controllers
{
    public class AktorlerController : Controller
    {
        private readonly Veritabani _context;

        public AktorlerController(Veritabani context)
        {
            _context = context;
        }
        public IActionResult Index()
        {   
            var data= _context.Aktorler.ToList();   
            return View();
        }
    }
}
