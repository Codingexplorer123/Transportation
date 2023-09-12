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
        public string Email { get; set; }
        [RegularExpression(@"^(\d{10})$",ErrorMessage ="Telefon numarasi 10 rakamdan olusmalidir.")]
        public string? PhoneNumber { get; set; }
        [Required(AllowEmptyStrings = true)]
        public string? Adress { get; set; }
        [DisplayFormat(DataFormatString = "{0: dd/MM/yyyy}")]
        public DateTime DogumTarihi { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [RegularExpression("^[0-9]{11}$",ErrorMessage ="TC No 11 numaradan olusmalidir.")]
        public long TCNo { get; set; }

        public ICollection<Role>? Roller { get; set; } = new List<Role>();
        // Birden fazla kullanici ayni rolde olabilir hashset yerine liste yaptik
        public User()
        {
            Roller = new List<Role>();
        }

        //Her yeni User eklendiginde userden gelen rolude roller listesine ekleyecegiz.


    }
}
