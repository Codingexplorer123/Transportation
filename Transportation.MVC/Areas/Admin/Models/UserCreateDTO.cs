using System.ComponentModel.DataAnnotations;

namespace Transportation.MVC.Areas.Admin.Models
{
    public class UserCreateDTO
    {
        public string? UserName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage="Email alani zorunludur")]
        [DataType(DataType.EmailAddress)]
        public string  Email { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Sifre alani zorunludur")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Sifre alani zorunludur")]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string Repassword { get; set; }
    }
}
