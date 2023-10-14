using TransportationEntity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Transportation.MVC.Models.DTOs
{
    public class NakliyeCreateDTO
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int NakliyeId { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Nakliye Yapildimi alani zorunludur")]
        public bool NakliyeYapildimi { get; set; }


        public string? MusteriDegerlendirmeleri { get; set; }

        public string? Aciklama { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime TalepTarihi { get; set; } = DateTime.Now;

        public int? AracId { get; set; }
        public int? RezervasyonId { get; set; }


    }
}
