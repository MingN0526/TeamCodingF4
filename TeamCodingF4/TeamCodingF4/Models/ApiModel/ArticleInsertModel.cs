using System.ComponentModel.DataAnnotations.Schema;

namespace TeamCodingF4.Models.ApiModel
{
    public class ArticleInsertModel
    {
        public int ArticleId { get; set; }
        /// <summary>
        /// 文章日期
        /// </summary>
        public DateTime Date { get; set; }
        /// <summary>
        /// 文章發佈者
        /// </summary>
       
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

    }
}
