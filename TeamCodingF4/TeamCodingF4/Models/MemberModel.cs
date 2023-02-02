using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Cryptography.Pkcs;

namespace TeamCodingF4.Models
{
    [Table("Members")]
    public class MemberModel
    {
        [Key]
        public int MemberId { get; set; }

        /// <summary>
        /// 會員身分別
        /// </summary>
        public string MemberRole { get; set; }

        /// <summary>
        /// 會員姓名
        /// </summary>
        public string MemberName { get; set; }

        /// <summary>
        /// 會員電話
        /// </summary>
        public string MemberPhone { get; set; }

        /// <summary>
        /// 會員帳號
        /// </summary>
        public string MemberAccount { get; set; }

        /// <summary>
        /// 會員密碼
        /// </summary>
        public string MemberPassword { get; set; }

        /// <summary>
        /// 會員信箱
        /// </summary>
        [EmailAddress]
        public string MemberEmail { get; set; }

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
        public string MemberGender { get; set; }

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
