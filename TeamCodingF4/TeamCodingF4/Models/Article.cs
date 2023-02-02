using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeamCodingF4.Models
{
    [Table("Articles")]
    public class Article
    {
        /// <summary>
        /// 文章ID
        /// </summary>
        [Key]
        public int ArticleId { get; set; }
        /// <summary>
        /// 文章日期
        /// </summary>
        [MaxLength(12)]
        [Column(TypeName = "varchar")]
        public string Date { get; set; }
        /// <summary>
        /// 文章發佈者
        /// </summary>
        [MaxLength(60)]
        [Column(TypeName = "nvarchar")]
        public string Publisher { get; set; }
        /// <summary>
        /// 文章分類
        /// </summary>
        [MaxLength(21)]
        [Column(TypeName = "nvarchar")]
        public string Category { get; set; }
        /// <summary>
        /// 文章內容
        /// </summary>
        [MaxLength(1200)]
        [Column(TypeName ="nvarchar")]
        public string Content { get; set; }
        /// <summary>
        /// 文章標題
        /// </summary>
        [MaxLength(60)]
        [Column(TypeName = "nvarchar")]
        public string Title { get; set; }

        public virtual ICollection<ArticleReply> ArticleReplies { get; set; }
    }
}
