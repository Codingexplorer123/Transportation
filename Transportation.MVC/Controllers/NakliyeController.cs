using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Transportation.Business.Abstract;
using Transportation.Data.Context;
using TransportationEntity;
using Transportation.MVC.Models.DTOs;
using Microsoft.AspNetCore.Mvc.Rendering;
using AutoMapper;
using Transportation.Business.Concrete;

namespace Transportation.MVC.Controllers
{
    // Buradaki Action Metodlarimizi Asenkron yapmak daha uygun cunku programin olceklendirilmesi acisindan ayni anda daha fazla http request
    //karsilamak icin cunku database e baglanmamiz gerekiyor(dis kaynak) verileri check etmek kaydetmek vs icin bosuna database
    // cevap verene kadar threadlerimiz bosta durmayip diger requestleri karsilamasi icin.

    [Authorize(Roles = "Admin,User")]
    public class NakliyeController : Controller
    {

        private readonly TransportationDbContext _context;
        private readonly INakliyeManager _manager;
        private readonly IMapper _mapper;

        public NakliyeController(TransportationDbContext context, INakliyeManager manager, IMapper mapper)
        {
            _context = context;
            _manager = manager;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetTumTalepler()
        {
            var talepler = await _manager.GetAllInclude(null, x => x.Araclar, x => x.Rezervasyon);
            return View(talepler);
        }

        [HttpGet]
        public async Task<IActionResult> Details(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            Nakliye nakliye = await _manager.GetByIdAsync((int)id);
            if(nakliye == null)
            {
                return NotFound();
            }
            return View(nakliye);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var nakliye = await _manager.GetAllAsync();
            return View();

        }

        [HttpPost]
        public async Task<IActionResult> Create(NakliyeCreateDTO talep)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var yeniKayit = _mapper.Map<Nakliye>(talep);
                await _manager.InsertAsync(yeniKayit);
                return RedirectToAction(nameof(GetTumTalepler));
            }
            catch (Exception)
            {

                return View(talep);
            }
        }
        [HttpGet]
        public async Task<IActionResult> TalepGuncelle (int id)
        {
            
             return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task <IActionResult> TalepGuncelle(int id, IFormCollection collection)
        {
            var idVarMi = await _manager.GetByIdAsync(id);
            if (idVarMi == null)
            {
                return View(idVarMi);
            }

            var NakliyeYapildimi = collection["NakliyeYapildimi"];
            var MusteriDegerlendirmesi = collection["MusteriDegerlendirmeleri"];
            string Aciklama = collection["Aciklama"];
            var TalepTarihi = collection["TalepTarihi"];
            var AracId = collection["AracId"];
            var RezervasyonId = collection["RezervasyonId"];

            idVarMi.NakliyeYapildimi = NakliyeYapildimi;
            idVarMi.MusteriDegerlendirmeleri = MusteriDegerlendirmesi;
            idVarMi.Aciklama = Aciklama;
            idVarMi.TalepTarihi = TalepTarihi;
            int.TryParse(idVarMi.AracId) = AracId;
            idVarMi.RezervasyonId = RezervasyonId;


            await _manager.UpdateAsync(idVarMi);
           

           
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
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
