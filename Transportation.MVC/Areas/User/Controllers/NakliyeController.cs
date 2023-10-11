using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Transportation.Business.Abstract;
using Transportation.Business.Concrete;
using Transportation.Data.Context;
using Transportation.MVC.Areas.Admin.Models;
using TransportationEntity;


namespace Transportation.MVC.Areas.User.Controllers
{
    [Area("User")]
    [Authorize(Roles = "Admin,User")]
    public class NakliyeController : Controller
    {

        private readonly NakliyeManager _manager;
        private readonly TransportationDbContext _context;
        private readonly IMapper _mapper;

        public NakliyeController(INakliyeManager manager, IMapper mapper, TransportationDbContext dbContext)
        {
            _manager = (NakliyeManager?)manager;
            _mapper = mapper;
            _context = dbContext;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var talepler = await _manager.GetAllInclude(null, x => x.Araclar, x => x.Rezervasyon);
            // Nakliyelerin iliskili oldugu tablolarida getirdik.
            return View(talepler);
        }


       
        public async Task<IActionResult> GetTalep(int id)

        {
            var talep = await _context.Nakliyeler.FirstOrDefaultAsync(x => x.NakliyeId == id);
            if (talep == null)
            {
                return BadRequest();
            }
            return View(talep);
        }
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(NakliyeCreateDTO nakliyeCreateDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var result = _mapper.Map<Nakliye>(nakliyeCreateDTO);
            // nakliyecreatedto den gelen verileri automapper ile entitye aktarmak icin
            _context.Nakliyeler.Add(result);
            await _context.SaveChangesAsync();
            return RedirectToAction();
        }


        [HttpGet]
        public async Task<IActionResult> Edit(int id, [FromBody] Nakliye guncelleme)
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
