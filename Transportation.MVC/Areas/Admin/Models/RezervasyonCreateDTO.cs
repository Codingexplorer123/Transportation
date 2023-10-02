using System.ComponentModel.DataAnnotations;
using TransportationEntity;

namespace Transportation.MVC.Areas.Admin.Models
{
    public class RezervasyonCreateDTO
    {

        [DataType(DataType.DateTime)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? RezervasyonTarihi { get; set; }

        [Required]
        public string NakliyeFirmasiAdi { get; set; }

        [Required(AllowEmptyStrings = false,ErrorMessage ="Sirketin emaili yazilmasi gerekmektedir.")]
        [DataType(DataType.EmailAddress)]
        public string NakliyeFirmasiEmail { get; set; }

       

    }
}
