using Microsoft.AspNetCore.Mvc;
using Transportation.Data.Context;
using TransportationEntity;

namespace Transportation.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NakliyeController : ControllerBase
    {

        private readonly TransportationDbContext _context;

        public NakliyeController(TransportationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetTumTalepler()
        {
            var talepler = _context.Nakliyeler.ToList();
            return Ok(talepler);
        }

        [HttpGet("{id}")]
        public IActionResult GetTalep(int id)
        {
            var talep = _context.Nakliyeler.FirstOrDefault(x=>x.NakliyatId == id);
            if (talep == null)
            {
                return BadRequest();
            }
            return Ok(talep);
        }
        [HttpPost]
        public IActionResult TalepOlustur(Nakliye talep)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            
            _context.Nakliyeler.Add(talep);
            _context.SaveChanges();
            return StatusCode(201);
        }


        [HttpPut("{id}")]
        public IActionResult TalepGuncelle(int id, [FromBody] Nakliye guncelleme)
        {
            Nakliye mevcut = _context.Nakliyeler.SingleOrDefault(x => x.NakliyatId == id);

            if (mevcut is null)
                return NotFound();

            mevcut.TalepTipi = guncelleme.TalepTipi != default ? guncelleme.TalepTipi : mevcut.TalepTipi;
            mevcut.TalepTarihi = guncelleme.TalepTarihi != default ? guncelleme.TalepTarihi : mevcut.TalepTarihi;
            mevcut.Aciklama = guncelleme.Aciklama != default ? guncelleme.Aciklama : mevcut.Aciklama;
            
            _context.SaveChanges();
            return Ok();
        }
    }
}
