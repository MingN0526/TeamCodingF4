using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeamCodingF4.Models
{
    public class ArticleReply
    {
        [Key]
        public int ReplyId { get; set; }
        [MaxLength(1200)]
        [Column(TypeName ="nvarchar")]
        public string ReplyContent { get; set; }
        [MaxLength(60)]
        [Column(TypeName = "nvarchar")]
        public string ReplyPublisher { get; set; }
        [MaxLength(12)]
        [Column(TypeName = "varchar")]
        public string ReplyDate { get; set;}
        public virtual Article Article { get; set; }




    }
}
