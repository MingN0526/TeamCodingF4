using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Cryptography.Pkcs;

namespace TeamCodingF4.Models
{
    [Table("MemberModel")]
    public class MemberModel : IdentityUser<int>
    {
        /// <summary>
        /// 會員身分證
        /// </summary>
        public string MemberIdentity { get; set; }

        /// <summary>
        /// 會員生日
        /// </summary>
        [StringLength(64)]
        public string MemberBirth { get; set; }

        /// <summary>
        /// 會員性別
        /// </summary>
        [StringLength(64)]
        public string MemberSex { get; set; }

        /// <summary>
        /// 會員信用等級
        /// </summary>
        [StringLength(64)]
        public string MemberRate { get; set; }

        /// <summary>
        /// 會員職業
        /// </summary>
        [StringLength(64)]
        public string MemberJob { get; set; }

        public virtual ICollection<MemberLike> MemberLikes { get; set; }
    }
}
