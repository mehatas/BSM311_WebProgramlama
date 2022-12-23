using System.ComponentModel.DataAnnotations;

namespace WebProje.Models
{
    public class Sinema
    {
        [Key]
        public int Id { get; set; }
        public string Logo { get; set; }
        public string Isim { get; set; }
        public string Aciklama { get; set; }


    }
}
