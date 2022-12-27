using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eBiletApp.Models
{
    public class Kullanici:IdentityUser
    {
        [Display(Name="Adı Soyadı")]
        public string AdSoyad { get; set; }
    }
}
