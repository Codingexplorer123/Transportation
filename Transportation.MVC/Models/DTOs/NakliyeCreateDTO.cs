using TransportationEntity;
using System.ComponentModel.DataAnnotations;

namespace Transportation.MVC.Models.DTOs
{
    public class NakliyeCreateDTO
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Nakliye Yapildimi alani zorunludur")]
        public bool NakliyeYapildimi { get; set; }


        public string? MusteriDegerlendirmeleri { get; set; }

        public string? Aciklama { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime TalepTarihi { get; set; } = DateTime.Now;


    }
}
