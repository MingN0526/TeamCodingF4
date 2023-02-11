using System.ComponentModel.DataAnnotations.Schema;

namespace TeamCodingF4.Models.ApiModel
{
    public class ArticleReplyInsertModel
    {
        public int Id { get; set; }
        /// <summary>
        /// 文章日期
        /// </summary>
        public DateTime Date { get; set; }
        /// <summary>
        /// 文章發佈者
        /// </summary>
      
        public int PublisherId { get; set; }
        /// <summary>
        /// 文章內容
        /// </summary>
        public string Content { get; set; }
     
        public int ArticleId { get; set; }
    }
}
