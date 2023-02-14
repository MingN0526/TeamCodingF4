using TeamCodingF4.Data.Entity;

namespace TeamCodingF4.Models.ApiModel
{
    public class EquipmentModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Picture { get; set; }
        public virtual ICollection<Estate> Estate { get; set; }
    }
}
