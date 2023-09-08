using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportationEntity
{
    public class User
    {
        [StringLength(20,ErrorMessage ="Isim 20 karakterden fazla olamaz")]
        [Required]
        [RegularExpression(".*[a-zA]+.*",ErrorMessage = "Lutfen harf giriniz")]
        public string Name { get; set; }
        [Required]
        [RegularExpression(".*[a-zA]+.*", ErrorMessage = "Lutfen harf giriniz")]
        public string LastName { get; set; }
        [EmailAddress]
        public string? Email { get; set; }
        [Phone]
        public string? PhoneNumber { get; set; }
        [Required(AllowEmptyStrings = true)]
        public string Adress { get; set; }
    }
}
