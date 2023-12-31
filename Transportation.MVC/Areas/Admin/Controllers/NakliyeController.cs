﻿using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Transportation.Business.Abstract;
using Transportation.Data.Context;
using TransportationEntity;
using Transportation.Data.Repository.Concrete;

namespace Transportation.MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin,User")]
    public class NakliyeController : Controller
    {

            private readonly INakliyeManager _Nakliyemanager;
            private readonly IMapper _Mapper;
            private readonly TransportationDbContext _context;
           
            public NakliyeController(INakliyeManager nakliyeManager,IMapper mapper,TransportationDbContext context )
            {
                _Nakliyemanager = nakliyeManager;
                _Mapper = mapper;
                _context = context;
             
            }

            [HttpGet]
            public async Task<IActionResult> GetTumTalepler()
            {
            var talepler = await _Nakliyemanager.GetAllAsync();
                
                return Ok(talepler);
            }

            [HttpGet]
            public async Task<IActionResult> GetTalep(int id)
            {
                var talep = await _context.Nakliyeler.FirstOrDefaultAsync(x => x.NakliyeId == id);
                if (talep == null)
                {
                    return BadRequest();
                }
                return Ok(talep);
            }
            [HttpPost]
            public async Task<IActionResult> TalepOlustur(Nakliye talep)
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                _context.Nakliyeler.Add(talep);
                _context.SaveChanges();
                return StatusCode(201);
            }


            [HttpPut("{id}")]
            public async Task<IActionResult> TalepGuncelle(int id, [FromBody] Nakliye guncelleme)
            {
                Nakliye mevcut = await _context.Nakliyeler.SingleOrDefaultAsync(x => x.NakliyeId == id);

                if (mevcut is null)
                    return NotFound();

                mevcut.MusteriDegerlendirmeleri = guncelleme.MusteriDegerlendirmeleri != default ? guncelleme.MusteriDegerlendirmeleri : mevcut.MusteriDegerlendirmeleri;
                mevcut.TalepTarihi = guncelleme.TalepTarihi != default ? guncelleme.TalepTarihi : mevcut.TalepTarihi;
                mevcut.Aciklama = guncelleme.Aciklama != default ? guncelleme.Aciklama : mevcut.Aciklama;

                _context.Nakliyeler.Update(guncelleme);
                _context.SaveChanges();
                return Ok();
            }
            [HttpDelete("{id}")]
            public async Task<ActionResult<Nakliye>> TalepSil(int? id)
            {
                if (id == null)
                {
                    return BadRequest("Lutfen id degerini giriniz");
                }
                var nakliye = await _context.Nakliyeler.FindAsync(id);
                if (nakliye == null)
                {
                    return NotFound("Girdiginiz id ye karsilik gelen bir deger yoktur");
                }
                _context.Nakliyeler.Remove(nakliye);
                _context.SaveChanges();
                return Ok();
            }
        }
}
