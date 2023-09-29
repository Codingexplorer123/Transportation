using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Transportation.Business.Abstract;
using Transportation.Business.Concrete;
using Transportation.Data.Context;
using TransportationEntity;

namespace Transportation.MVC.Areas.Controllers
{
    [Area("User")]
    [Authorize(Roles = "Admin,User")]
    public class NakliyeController : Controller
    {

        private readonly NakliyeManager _manager;

        private readonly IMapper _mapper;

        public NakliyeController(INakliyeManager manager,IMapper mapper)
        {
            _manager = (NakliyeManager?)manager;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetTumTalepler()
        {
            var talepler = await _manager.GetAllInclude(null, x => x.Araclar, x => x.Rezervasyon);
            // Nakliyelerin iliskili oldugu tablolarida getirdik.
            return View(talepler);
        }

        [HttpGet("{id}")]
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
