using System.ComponentModel.DataAnnotations;
using TransportationEntity;

namespace Transportation.MVC.Areas.Admin.Models
{
    public class AracCreateDTO
    {
        [Required(AllowEmptyStrings =false,ErrorMessage ="Arac Tipi girilmek zorundadir")]
        public AracTipi AracTipi { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Arac Soforu ismi girilmek zorundadir")]
        [RegularExpression("^[a-Za-Z]")]
        public string AracSoforuIsim { get; set; }
        
        [Required(AllowEmptyStrings = false, ErrorMessage = "Arac Soforu ismi girilmek zorundadir")]
        [RegularExpression("^[a-Za-Z]")]
        public string AracSoforuSoyisim { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Arac Soforu ismi girilmek zorundadir")]
        [RegularExpression("^[a-Za-Z]")]
        public string AracPlakaNo { get; set; }

        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^(\d{10})$", ErrorMessage = "Telefon numarasi 10 rakamdan olusmalidir.")]
        public string? AracSoforuTelNo { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Arac firma tel no girilmek zorundadir")]
        [DisplayFormat(DataFormatString = "{0:###-###-####}")]
        public string FirmaTelNo { get; set; }

        public Rezervasyon? Rezervasyon { get; set; }
        public Nakliye? Nakliye { get; set; }
    }
}
