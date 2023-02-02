using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeamCodingF4.Data.Entity
{
    public class Articles
    {
        /// <summary>
        /// 文章ID
        /// </summary>
        [Key]
        public int ArticleId { get; set; }
        /// <summary>
        /// 文章日期
        /// </summary>
        public DateTime Date { get; set; }
        /// <summary>
        /// 文章發佈者
        /// </summary>
        [ForeignKey("Member")]
        public int PublisherId { get; set; }
        /// <summary>
        /// 文章分類
        /// </summary>
        public string Category { get; set; }
        /// <summary>
        /// 文章內容
        /// </summary>
        public string Content { get; set; }
        /// <summary>
        /// 文章標題
        /// </summary>
        public string Title { get; set; }

        public int ViewCount { get; set; }

        public virtual Member Member { get; set; }
        public virtual ICollection<ArticleReply> ArticleReplies { get; set; }
        public virtual ICollection<ArticleLike> ArticleLikes { get; set; }
    }
}
