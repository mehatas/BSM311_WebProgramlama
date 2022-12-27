﻿using eBiletApp.Data.Repositories.Abstract;
using eBiletApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBiletApp.Data.Repositories
{
    public class SiparisRepository : ISiparisRepository
    {
        private readonly BiletDbContext _context;
        public SiparisRepository(BiletDbContext context)
        {
            _context = context;
        }

        public async Task SiparisiKaydet(ICollection<Sepet> urunler, string kullaniciId, string kullaniciEmail)
        {
            var siparis = new Siparis();

            siparis.KullaniciId = kullaniciId;
            siparis.KullaniciEmail = kullaniciEmail;

            await _context.Siparisler.AddAsync(siparis);
            await _context.SaveChangesAsync();

            foreach(var urun in urunler)
            {
                var siparisFilm = new SiparisFilm()
                {
                    Adet = urun.Adet,
                    FilmId = urun.Film.FilmId,
                    Fiyat = urun.Film.FilmUcreti,
                    SiparisId = siparis.SiparisId
                };
                await _context.SiparisFilmler.AddAsync(siparisFilm);
                await _context.SaveChangesAsync();
            }
          
        }

        public async Task<ICollection<Siparis>> SiparisleriGetir(string kullaniciId, string rol)
        {
            var siparisler = await _context.Siparisler.Include(m => m.SiparisFilmler).ThenInclude(m => m.Film).Include(m=>m.Kullanici).ToListAsync();
            if(rol!="Admin")
            {
                siparisler = siparisler.Where(m => m.KullaniciId == kullaniciId).ToList();
            }
            return siparisler;
        }
    }
}
