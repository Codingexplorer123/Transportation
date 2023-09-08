using System.ComponentModel.DataAnnotations;

namespace TransportationEntity
{
    public class Nakliye
    {
        public int NakliyatId  { get; set; }
        [Required]
        public string TalepTipi { get; set; }

        public string Aciklama { get; set; }

        public DateTime TalepTarihi { get; set; }

    }
}