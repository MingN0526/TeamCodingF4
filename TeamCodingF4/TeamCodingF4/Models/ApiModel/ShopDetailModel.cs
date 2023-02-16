using TeamCodingF4.Data.Entity;

namespace TeamCodingF4.Models.ApiModel
{
    public class ShopDetailModel
    {
        public int Id { get; set; }
        public string Tittle { get; set; }
        public int RoomTypeId { get; set; }
        public int Room { get; set; }
        public int Hall { get; set; }
        public int Bathroom { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string Address { get; set; }
        public string Floor { get; set; }
        public decimal Price { get; set; }
        public decimal Miscellaneous { get; set; }
        public float Meters { get; set; }
        public int Car { get; set; }
        public int Motorcycle { get; set; }
        public int Lease { get; set; }
        public string EstateVideoPath { get; set; }
        public string? Message { get; set; }
        public List<string> Images { get; set; }
        public string RoomTypeName { get; set; }


    }
}
