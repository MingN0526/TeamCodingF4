namespace TeamCodingF4.Models.ApiModel
{
    public class EstateIndexModel
    {
        public int Id { get; set; }
        public string Tittle { get; set; }
        public string RoomType { get; set; }

        public decimal Price { get; set; }
        public decimal Miscellaneous { get; set; }
    }
}
