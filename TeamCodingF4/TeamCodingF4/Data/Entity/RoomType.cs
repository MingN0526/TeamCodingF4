namespace TeamCodingF4.Data.Entity
{
    public class RoomType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<Estate> Estate { get; set; }
    }
}
