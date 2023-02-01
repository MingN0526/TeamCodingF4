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
        [StringLength(64)]
        public string ArticleDate { get; set; }
        /// <summary>
        /// 文章發佈者
        /// </summary>
        [StringLength(64)]
        public string ArticlePublisher { get; set; }
        /// <summary>
        /// 文章分類
        /// </summary>
        [StringLength(64)]
        public string ArticleCategory { get; set; }
        /// <summary>
        /// 文章內容
        /// </summary>
        [MaxLength(4000)]
        [Column(TypeName ="nvarchar")]
        public string ArticleContent { get; set; }
        /// <summary>
        /// 文章標題
        /// </summary>
        [MaxLength(60)]
        [Column(TypeName = "nvarchar")]
        public string ArticleTitle { get; set; }
    }
}
