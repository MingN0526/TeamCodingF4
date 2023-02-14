using System.ComponentModel.DataAnnotations;

namespace TeamCodingF4.Models.ApiModel
{
    public class AccountModel
    {
        public string Name { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "兩次密碼輸入不一致!")]
        [DataType(DataType.Password)]
        public string confirmPwd { get; set; }

    }
}
