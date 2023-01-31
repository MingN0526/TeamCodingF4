using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeamCodingF4.Models
{
    [Table("Articles")]
    public class Article
    {
        [Key]
        public int ArticleId { get; set; }
        [StringLength(64)]
        public string ArticleDate { get; set; }
        [StringLength(64)]
        public string ArticlePublisher { get; set; }
        [StringLength(64)]
        public string ArticleCategory { get; set; }
        [MaxLength(4000)]
        [Column(TypeName ="nvarchar")]
        public string ArticleContent { get; set; }
        [MaxLength(60)]
        [Column(TypeName = "nvarchar")]
        public string ArticleTitle { get; set; }
    }
}
