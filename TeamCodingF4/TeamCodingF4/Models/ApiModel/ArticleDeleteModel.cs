using System.ComponentModel.DataAnnotations.Schema;

namespace TeamCodingF4.Models.ApiModel
{
    public class ArticleDeleteModel
    {
        public int ArticleId { get; set; }
     
        public DateTime Date { get; set; }
    
        public int PublisherId { get; set; }
       
        public string Category { get; set; }
      
        public string Content { get; set; }
     
        public string Title { get; set; }

        public int ViewCount { get; set; }
    }
}
