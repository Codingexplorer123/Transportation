using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TransportationEntity
{
    public class Nakliye
    {
        public int NakliyeId { get; set; }
        public bool? NakliyeYapildimi { get; set; }

        public string? MusteriDegerlendirmeleri { get; set; }

        public string? Aciklama { get; set; }

        public DateTime TalepTarihi { get; set; } = DateTime.Now;


        public int? AracId { get; set; }
        [ForeignKey("RezervasyonId")]
        public int RezervasyonId { get; set; }
        public Rezervasyon? Rezervasyon { get; set; }
        public List<Arac>? Araclar { get; set; }

    }
}