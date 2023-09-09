using System.ComponentModel.DataAnnotations;

namespace TransportationEntity
{
    public class Nakliye
    {
        public int NakliyatId  { get; set; }
        [Required]
        public string TalepTipi { get; set; }

        public bool NakliyeYapildimi { get; set; }

        public string MusteriDegerlendirmeleri { get; set; }

        public string Aciklama { get; set; }

        public DateTime TalepTarihi { get; set; }

        public int RezervasyonId { get; set; }
        public int AracId { get; set; }
        public Rezervasyon Rezervasyon { get; set; }
        public List<Arac> Araclar { get; set; }

    }
}