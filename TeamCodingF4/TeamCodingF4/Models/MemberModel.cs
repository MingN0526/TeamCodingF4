using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeamCodingF4.Models
{
    [Table("MemberModel")]
    public class MemberModel
    {
        [Key]
        public int MemberId { get; set; } //會員Id
        [StringLength(64)]
        public string MemberName { get; set; } //會員姓名
        [StringLength(64)]
        public string MemberPhone { get; set; } //會員電話
        [StringLength(64)]
        public string MemberAccount { get; set; } //會員帳號
        [StringLength(64)]
        public string MemberPassword { get; set; } //會員密碼
        [StringLength(64)]
        public string MemberEmail { get; set; } //會員信箱
        [MaxLength(10)]
        public string MemberIdentity { get; set; } //會員身分證
        [StringLength(64)]
        public string MemberBirth { get; set; } //會員生日
        [StringLength(64)]
        public string MemberSex { get; set; } //會員性別
        [StringLength(64)]
        public string MemberRate { get; set; } //會員信用等級
        [StringLength(64)]
        public string MemberJob { get; set; } //會員職業
        [StringLength(64)]
        public string MemberSeparate { get; set; } //會員角色
        [StringLength(64)]
        public string MemberLike { get; set; } //會員物件喜好
    }
}
