namespace TeamCodingF4.Models.ApiModel
{
    public class EstateEditionModel
    {
        public int Id { get; set; }
        public string Tittle { get; set; }
        public int Room { get; set; }
        public int hall { get; set; }
        public int bathroom { get; set; }
        public string Address { get; set; }
        public string Floor { get; set; }
        public decimal Price { get; set; }
        public decimal Miscellaneous { get; set; }
        public float Meters { get; set; }
        public int Car { get; set; }
        public int Motorcycle { get; set; }
        public int Lease { get; set; }
        public string message { get; set; }
    }
}
