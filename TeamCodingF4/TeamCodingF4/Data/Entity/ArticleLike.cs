using System.ComponentModel.DataAnnotations.Schema;

namespace TeamCodingF4.Data.Entity
{
    public class ArticleLike
    {
        public int Id { get; set; }
        [ForeignKey("Articles")]
        public int ArticleId { get; set; }

        [ForeignKey("Member")]
        public int UserId { get; set; }

        public virtual Member Member { get; set; }
        public virtual Articles Articles { get; set; }
    }
}
