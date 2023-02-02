using System.ComponentModel.DataAnnotations.Schema;

namespace TeamCodingF4.Data.Entity
{
    public class EstateLike
    {
        public int Id { get; set; }
        public int Value { get; set; }

        [ForeignKey("Member")]
        public int UserId { get; set; }

        public virtual Member Member { get; set; }
    }
}
