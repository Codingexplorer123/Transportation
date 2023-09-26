using System.ComponentModel.DataAnnotations;

namespace Transportation.MVC.Models.DTOs
{
    public class ForgotDTO
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Email alani doldurulmasi zorunludur.")]
        // Kullanicinin eger email girmesse hata mesaji gonderdik.
        [DataType(DataType.EmailAddress, ErrorMessage = " Email adresinizi kontrol ediniz")]
        // Kullanicinin girdigi veriyi email formatinda mi diye kontrol ettik degilse hata mesaji gonderdik.
        public string Email { get; set; }
    }
}
