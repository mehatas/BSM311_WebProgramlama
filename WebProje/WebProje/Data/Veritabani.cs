using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using WebProje.Models;

namespace WebProje.Data
{
    public class Veritabani : DbContext
    {
        public Veritabani(DbContextOptions<Veritabani> options) : base(options)
        {


        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Aktor_Film>().HasKey(af => new
            {
                af.AktorId,
                af.FilmId

            });

            modelBuilder.Entity<Aktor_Film>().HasOne(f => f.Film).WithMany(af => af.Aktor_Filmler).HasForeignKey(f => f.FilmId);
            modelBuilder.Entity<Aktor_Film>().HasOne(f => f.Aktor).WithMany(af => af.Aktor_Filmler).HasForeignKey(f => f.AktorId);


            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Aktorler> Aktorler { get; set; }
        public DbSet<Film> Filmler { get; set; }
        public DbSet<Aktor_Film> Aktor_Filmler { get; set; }
        public DbSet<Sinema> Sinemalar { get; set; }
        public DbSet<Yapimcilar> Yapimcilar { get; set; }



    }

}

