using System.ComponentModel.DataAnnotations.Schema;

namespace TeamCodingF4.Data.Entity
{
    public class Equipment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Picture { get; set; }
        public virtual ICollection<Estate> Estate { get; set; }
    }
}
