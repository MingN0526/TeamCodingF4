using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TeamCodingF4.Data.Entity
{
    public class ArticleReply
    {
        /// <summary>
        /// 文章ID
        /// </summary>
        [Key]
        public int Id { get; set; }
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
        /// 文章內容
        /// </summary>
        public string Content { get; set; }
        [ForeignKey("Articles")]
        public int ArticleId { get; set; }


        public virtual Member Member { get; set; }
        public virtual Articles Article { get; set; }
    }
}
