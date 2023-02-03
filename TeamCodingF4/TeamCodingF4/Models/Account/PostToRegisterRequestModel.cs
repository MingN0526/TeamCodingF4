using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TeamCodingF4.Models.Account
{
    public class PostToRegisterRequestModel
    {
        [Required(ErrorMessage = "請輸入使用者名稱")]
        public string Name { get; set; }

        [Required(ErrorMessage = "請輸入信箱")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "請設置密碼")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "兩次密碼輸入不一致!")]
        [DataType(DataType.Password)]
        public string ConfirmePassword { get; set; }

    }
}
