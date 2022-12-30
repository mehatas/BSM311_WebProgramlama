using eBiletApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBiletApp.Data.Repositories.Abstract
{
    public interface ISiparisRepository
    {
        Task<ICollection<Siparis>> SiparisleriGetir(string kullaniciId, string rol);
        Task SiparisiKaydet(ICollection<Sepet> urunler, string kullaniciId, string kullaniciEmail);
    }
}
