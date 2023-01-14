using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeamCodingF4.Models
{
    [Table("ArticalModel")]
    public class ArticalModel
    {
        [Key]
        public int ArticalId { get; set; }
        [StringLength(64)]
        public string AriticalDate { get; set; }
        [StringLength(64)]
        public string ArticlePublisher { get; set; }
        [StringLength(64)]
        public string ArticleCategory { get; set; }
    }
}
