using System.ComponentModel.DataAnnotations;

namespace WebProje.Models
{
    public class Sinema
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Sinema Logo")]
        public string Logo { get; set; }
        [Display(Name = "Sinema Adı")]
        public string Isim { get; set; }
        [Display(Name = "Açıklama")]
        public string Aciklama { get; set; }

        List<Film> Filmler { get; set; }    


    }
}
