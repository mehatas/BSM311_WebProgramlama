using System.ComponentModel.DataAnnotations;
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
    }
}
