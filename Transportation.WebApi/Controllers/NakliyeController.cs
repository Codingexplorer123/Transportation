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
            
        }
    }
}
