using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeamCodingF4.Models
{
    public class ArticleReply
    {
        [Key]
        public int ArticleReplyId { get; set; }
        [MaxLength(4000)]
        [Column(TypeName ="nvarchar")]
        public string ReplyContent { get; set; }
        [MaxLength(66)]
        [Column(TypeName = "nvarchar")]
        public string ReplyPublisher { get; set; }
        [MaxLength(66)]
        [Column(TypeName = "varchar")]
        public string ReplyDate { get; set;}




    }
}
