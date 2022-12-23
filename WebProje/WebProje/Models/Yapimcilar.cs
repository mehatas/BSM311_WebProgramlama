using System.ComponentModel.DataAnnotations;

namespace WebProje.Models
{
    public class Yapimcilar
    {
        [Key]
        public int Id { get; set; }
        public string ProfilFotoURL { get; set; }
        public string Isim { get; set; }
        public string Biyografi { get; set; }
    }
}
