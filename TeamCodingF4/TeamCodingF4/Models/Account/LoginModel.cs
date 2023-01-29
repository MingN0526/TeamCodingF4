using System.ComponentModel.DataAnnotations;

namespace TeamCodingF4.Models.Account
{
    public class LoginModel
    {
        [Required(ErrorMessage = "請輸入信箱")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "請輸入密碼")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public bool RememberMe { get; set; }

    }
}
