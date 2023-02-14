using System.ComponentModel.DataAnnotations;

namespace TeamCodingF4.Models.ApiModel
{
    public class MemberModel
    {
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// 會員姓名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 會員電話
        /// </summary>
        public string? Phone { get; set; }

        /// <summary>
        /// 會員信箱
        /// </summary>
        [EmailAddress]
        public string Email { get; set; }

        /// <summary>
        /// 會員身分證
        /// </summary>
        public string? Identity { get; set; }

        /// <summary>
        /// 會員生日
        /// </summary>       
        public DateTime? BirthDate { get; set; }

        /// <summary>
        /// 會員性別
        /// </summary>
        public int? Gender { get; set; }

        /// <summary>
        /// 會員職業
        /// </summary>
        public string? Job { get; set; }

        public string? PicturePath { get; set; }
        public string? Address { get; set; }


    }
}
