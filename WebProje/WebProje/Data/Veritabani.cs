using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace WebProje.Data
{
    public class Veritabani:DbContext
    {
        public Veritabani(DbContextOptions<Veritabani> options) :base(options) { }
    }
}
