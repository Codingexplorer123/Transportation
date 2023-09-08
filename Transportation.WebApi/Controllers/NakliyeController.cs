using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Transportation.Data.Context;
using TransportationEntity;

namespace Transportation.WebApi.Controllers
{
    // Buradaki Action Metodlarimizi Asenkron yapmak daha uygun cunku programin olceklendirilmesi acisindan ayni anda daha fazla http request
    //karsilamak icin cunku database e baglanmamiz gerekiyor(dis kaynak) verileri check etmek kaydetmek vs icin bosuna database
    // cevap verene kadar threadlerimiz bosta durmayip diger requestleri karsilamasi icin.
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
        public async Task <IActionResult> GetTumTalepler()
        {
            var talepler = await _context.Nakliyeler.ToListAsync();
            return Ok(talepler);
        }

        [HttpGet("{id}")]
        public async Task <IActionResult> GetTalep(int id)
        {
            var talep = await _context.Nakliyeler.FirstOrDefaultAsync(x=>x.NakliyatId == id);
            if (talep == null)
            {
                return BadRequest();
            }
            return Ok(talep);
        }
        [HttpPost]
        public async Task <IActionResult> TalepOlustur(Nakliye talep)
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
        public async Task <IActionResult> TalepGuncelle(int id, [FromBody] Nakliye guncelleme)
        {
            Nakliye mevcut = await _context.Nakliyeler.SingleOrDefaultAsync(x => x.NakliyatId == id);

            if (mevcut is null)
                return NotFound();

            mevcut.TalepTipi = guncelleme.TalepTipi != default ? guncelleme.TalepTipi : mevcut.TalepTipi;
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
