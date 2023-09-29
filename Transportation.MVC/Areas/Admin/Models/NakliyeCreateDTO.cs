using System.ComponentModel.DataAnnotations;

namespace Transportation.MVC.Areas.Admin.Models
{
    public class NakliyeCreateDTO
    {

        public int NakliyeId { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage ="Bu alan girilmelidir")]
        public bool? NakliyeYapildimi { get; set; }

        public string? MusteriDegerlendirmeleri { get; set; }

        public string? Aciklama { get; set; }

        public DateTime TalepTarihi { get; set; } = DateTime.Now;


        public int? AracId { get; set; }
    }
}
