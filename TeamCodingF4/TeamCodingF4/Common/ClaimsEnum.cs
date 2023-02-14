using System.ComponentModel.DataAnnotations;

namespace TeamCodingF4.Common
{
    public enum ClaimsEnum
    {
        [Display(Name = "房東")]
        房東 = 0,
        [Display(Name = "房客")]
        房客 = 1,
        [Display(Name = "訪客")]
        訪客 = 9,

    }
}
