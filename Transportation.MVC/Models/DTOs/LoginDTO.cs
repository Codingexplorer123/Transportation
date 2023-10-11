using System.ComponentModel.DataAnnotations;

namespace Transportation.MVC.Models.DTOs
{
    // client side validasyonlar icin LoginDTO classimizin icerisine Data Annotation yontemi ile ilk olarak client tarafindan gerekli veriyi
    // front end tarafinda almaya calisacagiz.
    public class LoginDTO
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Email alani doldurulmasi zorunludur.")]
        // Kullanicinin eger email girmesse hata mesaji gonderdik.
        [DataType(DataType.EmailAddress, ErrorMessage = " Email adresinizi kontrol ediniz")]
        // Kullanicinin girdigi veriyi email formatinda mi diye kontrol ettik degilse hata mesaji gonderdik.
        public string Email { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Sifre girilmesi zorunludur.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        
        public bool RememberMe { get; set; } 
        
    }
}
