using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebProje.Data.Enums;

namespace WebProje.Models
{
    public class Film
    {
        [Key]
        public int Id { get; set; }
        public string Isim { get; set; }
        public string Aciklama { get; set; }
        public double Fiyat { get; set; }
        public string AfisURL { get; set; }
        public DateTime Baslangic { get; set; }
        public DateTime Bitis { get; set; }
        public Kategori Kategori { get; set; }

        public List<Aktor_Film> Aktor_Filmler { get; set; }

        //sinema
        public int SinemaId { get; set; }
        [ForeignKey("SinemaId")]
        public Sinema Sinema { get; set; }


        //yapimci
        public int YapimciId { get; set; }
        [ForeignKey("YapimciId")]
        public Yapimcilar Yapimci { get; set; }


    }
}
