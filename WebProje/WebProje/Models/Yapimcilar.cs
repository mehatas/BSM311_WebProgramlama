using System.ComponentModel.DataAnnotations;

namespace WebProje.Models
{
    public class Yapimcilar
    {
        [Key]
        public int Id { get; set; }
        [Display(Name ="Profil Fotografi")]
        public string ProfilFotoURL { get; set; }
        [Display(Name = "İsim")]
        public string Isim { get; set; }
        [Display(Name = "Biyografi")]
        public string Biyografi { get; set; }


        public List<Film> Filmler { get; set; } 

    }
}
