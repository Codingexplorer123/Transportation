using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportationEntity
{
    public class User
    {
        public int UserId { get; set; }

        [RegularExpression(".*[a-zA]+.*",ErrorMessage = "Lutfen harf giriniz")]
        public string Name { get; set; }
        
        [RegularExpression(".*[a-zA]+.*", ErrorMessage = "Lutfen harf giriniz")]
        public string LastName { get; set; }
        [EmailAddress]
        public string? Email { get; set; }
        [Phone]
        public string? PhoneNumber { get; set; }
        [Required(AllowEmptyStrings = true)]
        public string? Adress { get; set; }
        [DisplayFormat(DataFormatString = "{0: dd/MM/yyyy}")]
        public DateTime DogumTarihi { get; set; } 
        public string Password { get; set; }
        public long TCNo { get; set; }


    }
}
