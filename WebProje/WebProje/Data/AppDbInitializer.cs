using WebProje.Data.Enums;
using WebProje.Models;

namespace WebProje.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context= serviceScope.ServiceProvider.GetService<Veritabani>();
                context.Database.EnsureCreated();

                //sinema
                if (!context.Sinemalar.Any())
                {
                    context.Sinemalar.AddRange(new List<Sinema>()
                    {
                        new Sinema()
                        {
                            Isim = "Sinema 1",
                            Logo = "http://dotnethow.net/images/Sinemalar/Sinema-1.jpeg",
                            Aciklama = "This is the Aciklama of the first Sinema"
                        },
                        new Sinema()
                        {
                            Isim = "Sinema 2",
                            Logo = "http://dotnethow.net/images/Sinemalar/Sinema-2.jpeg",
                            Aciklama = "This is the Aciklama of the first Sinema"
                        },
                        new Sinema()
                        {
                            Isim = "Sinema 3",
                            Logo = "http://dotnethow.net/images/Sinemalar/Sinema-3.jpeg",
                            Aciklama = "This is the Aciklama of the first Sinema"
                        },
                        new Sinema()
                        {
                            Isim = "Sinema 4",
                            Logo = "http://dotnethow.net/images/Sinemalar/Sinema-4.jpeg",
                            Aciklama = "This is the Aciklama of the first Sinema"
                        },
                        new Sinema()
                        {
                            Isim = "Sinema 5",
                            Logo = "http://dotnethow.net/images/Sinemalar/Sinema-5.jpeg",
                            Aciklama = "This is the Aciklama of the first Sinema"
                        },
                    });
                    context.SaveChanges();
                }

                if (!context.Aktorler.Any())
                {
                    context.Aktorler.AddRange(new List<Aktorler>()
                    {
                        new Aktorler()
                        {
                            Isim = "Actor 1",
                            Biyografi = "This is the Bio of the first actor",
                            ProfilFotoURL = "http://dotnethow.net/images/actors/actor-1.jpeg"

                        },
                        new Aktorler()
                        {
                            Isim = "Actor 2",
                            Biyografi = "This is the Bio of the second actor",
                            ProfilFotoURL = "http://dotnethow.net/images/actors/actor-2.jpeg"
                        },
                        new Aktorler()
                        {
                            Isim = "Actor 3",
                            Biyografi = "This is the Bio of the second actor",
                            ProfilFotoURL = "http://dotnethow.net/images/actors/actor-3.jpeg"
                        },
                        new Aktorler()
                        {
                            Isim = "Actor 4",
                            Biyografi = "This is the Bio of the second actor",
                            ProfilFotoURL = "http://dotnethow.net/images/actors/actor-4.jpeg"
                        },
                        new Aktorler()
                        {
                            Isim = "Actor 5",
                            Biyografi = "This is the Bio of the second actor",
                            ProfilFotoURL = "http://dotnethow.net/images/actors/actor-5.jpeg"
                        }
                    });
                    context.SaveChanges();
                }

                if (!context.Yapimcilar.Any())
                {
                    context.Yapimcilar.AddRange(new List<Yapimcilar>()
                    {
                        new Yapimcilar()
                        {
                            Isim = "Producer 1",
                            Biyografi = "This is the Bio of the first actor",
                            ProfilFotoURL = "http://dotnethow.net/images/producers/producer-1.jpeg"

                        },
                        new Yapimcilar()
                        {
                            Isim = "Producer 2",
                            Biyografi = "This is the Bio of the second actor",
                            ProfilFotoURL = "http://dotnethow.net/images/producers/producer-2.jpeg"
                        },
                        new Yapimcilar()
                        {
                            Isim = "Producer 3",
                            Biyografi = "This is the Bio of the second actor",
                            ProfilFotoURL = "http://dotnethow.net/images/producers/producer-3.jpeg"
                        },
                        new Yapimcilar()
                        {
                            Isim = "Producer 4",
                            Biyografi = "This is the Bio of the second actor",
                            ProfilFotoURL = "http://dotnethow.net/images/producers/producer-4.jpeg"
                        },
                        new Yapimcilar()
                        {
                            Isim = "Producer 5",
                            Biyografi = "This is the Bio of the second actor",
                            ProfilFotoURL = "http://dotnethow.net/images/producers/producer-5.jpeg"
                        }
                    });
                    context.SaveChanges();
                }

                if (!context.Filmler.Any())
                {
                    context.Filmler.AddRange(new List<Film>()
                    {
                        new Film()
                        {
                            Isim = "Life",
                            Aciklama = "This is the Life movie description",
                            Fiyat = 39.50,
                            AfisURL = "http://dotnethow.net/images/movies/movie-3.jpeg",
                            Baslangic = DateTime.Now.AddDays(-10),
                            Bitis = DateTime.Now.AddDays(10),
                            SinemaId = 3,
                            YapimciId = 3,
                            Kategori = Kategori.Belgesel
                        },
                        new Film()
                        {
                            Isim = "The Shawshank Redemption",
                            Aciklama = "This is the Shawshank Redemption description",
                            Fiyat = 29.50,
                            AfisURL = "http://dotnethow.net/images/movies/movie-1.jpeg",
                            Baslangic = DateTime.Now,
                            Bitis = DateTime.Now.AddDays(3),
                            SinemaId = 1,
                            YapimciId = 1,
                            Kategori = Kategori.Aksiyon
                        },
                        new Film()
                        {
                            Isim = "Ghost",
                            Aciklama = "This is the Ghost movie description",
                            Fiyat = 39.50,
                            AfisURL = "http://dotnethow.net/images/movies/movie-4.jpeg",
                            Baslangic = DateTime.Now,
                            Bitis = DateTime.Now.AddDays(7),
                            SinemaId = 4,
                            YapimciId = 4,
                            Kategori = Kategori.Korku
                        },
                        new Film()
                        {
                            Isim = "Race",
                            Aciklama = "This is the Race movie description",
                            Fiyat = 39.50,
                            AfisURL = "http://dotnethow.net/images/movies/movie-6.jpeg",
                            Baslangic = DateTime.Now.AddDays(-10),
                            Bitis = DateTime.Now.AddDays(-5),
                            SinemaId = 1,
                            YapimciId = 2,
                            Kategori = Kategori.Belgesel
                        },
                        new Film()
                        {
                            Isim = "Scoob",
                            Aciklama = "This is the Scoob movie description",
                            Fiyat = 39.50,
                            AfisURL = "http://dotnethow.net/images/movies/movie-7.jpeg",
                            Baslangic = DateTime.Now.AddDays(-10),
                            Bitis = DateTime.Now.AddDays(-2),
                            SinemaId = 1,
                            YapimciId = 3,
                            Kategori = Kategori.Animasyon
                        },
                        new Film()
                        {
                            Isim = "Cold Soles",
                            Aciklama = "This is the Cold Soles movie description",
                            Fiyat = 39.50,
                            AfisURL = "http://dotnethow.net/images/movies/movie-8.jpeg",
                            Baslangic = DateTime.Now.AddDays(3),
                            Bitis = DateTime.Now.AddDays(20),
                            SinemaId = 1,
                            YapimciId = 5,
                            Kategori = Kategori.Dram
                        }
                    });
                    context.SaveChanges();
                }

                if (!context.Aktor_Filmler.Any())
                {
                    context.Aktor_Filmler.AddRange(new List<Aktor_Film>()
                    {
                        new Aktor_Film()
                        {
                            AktorId = 1,
                            FilmId = 1
                        },
                        new Aktor_Film()
                        {
                            AktorId = 3,
                            FilmId = 1
                        },

                         new Aktor_Film()
                        {
                            AktorId = 1,
                            FilmId = 2
                        },
                         new Aktor_Film()
                        {
                            AktorId = 4,
                            FilmId = 2
                        },

                        new Aktor_Film()
                        {
                            AktorId = 1,
                            FilmId = 3
                        },
                        new Aktor_Film()
                        {
                            AktorId = 2,
                            FilmId = 3
                        },
                        new Aktor_Film()
                        {
                            AktorId = 5,
                            FilmId = 3
                        },


                        new Aktor_Film()
                        {
                            AktorId = 2,
                            FilmId = 4
                        },
                        new Aktor_Film()
                        {
                            AktorId = 3,
                            FilmId = 4
                        },
                        new Aktor_Film()
                        {
                            AktorId = 4,
                            FilmId = 4
                        },


                        new Aktor_Film()
                        {
                            AktorId = 2,
                            FilmId = 5
                        },
                        new Aktor_Film()
                        {
                            AktorId = 3,
                            FilmId = 5
                        },
                        new Aktor_Film()
                        {
                            AktorId = 4,
                            FilmId = 5
                        },
                        new Aktor_Film()
                        {
                            AktorId = 5,
                            FilmId = 5
                        },


                        new Aktor_Film()
                        {
                            AktorId = 3,
                            FilmId = 6
                        },
                        new Aktor_Film()
                        {
                            AktorId = 4,
                            FilmId = 6
                        },
                        new Aktor_Film()
                        {
                            AktorId = 5,
                            FilmId = 6
                        },
                    });
                    context.SaveChanges();

                }
            }
        }
    }
}
