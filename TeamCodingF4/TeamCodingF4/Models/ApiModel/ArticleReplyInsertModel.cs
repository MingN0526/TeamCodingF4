using System.ComponentModel.DataAnnotations.Schema;

namespace TeamCodingF4.Models.ApiModel
{
    public class ArticleReplyInsertModel
    {
        /// <summary>
        /// 文章內容
        /// </summary>
        public string Content { get; set; }

        public int ArticleId { get; set; }
    }
}
