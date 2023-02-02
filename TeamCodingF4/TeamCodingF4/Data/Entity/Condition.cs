namespace TeamCodingF4.Data.Entity
{
    public class Condition
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Estate> Estate { get; set;}
    }
}
