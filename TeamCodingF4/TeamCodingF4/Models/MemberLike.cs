using System.ComponentModel.DataAnnotations.Schema;

namespace TeamCodingF4.Models
{
    public class MemberLike
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Value { get; set; }

        [ForeignKey("Member")]
        public int UserId { get; set; }

        public virtual MemberModel Member { get; set; }
    }
}
