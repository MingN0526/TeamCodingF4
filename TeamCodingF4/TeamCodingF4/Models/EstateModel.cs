using System.ComponentModel.DataAnnotations;

namespace TeamCodingF4.Models
{
    public class EstateModel
    {
        [Key]
        public int EstateId { get; set; }
        public string EstateTittle { get; set; }
        public string RoomType { get; set; }
        public string Address { get; set; }
        public string EststePrice { get; set; }
        public string Miscellaneous { get; set; }
        public string Meters { get; set; }
        public int Car { get; set; }
        public int Motorcycle { get; set; }
        public bool AirConditioner { get; set; }
        public bool Television { get; set; }
        public bool WetDry { get; set; }
        public bool Balcony { get; set; }
        public bool WashingMachine { get; set; }
        public bool WaterDispenser { get; set; }
        public bool Refrigerator { get; set; }
        public string Lease { get; set; }
        public string EstatePicture { get; set; }
        public string EstateVideo { get; set; }
        public string? message { get; set; }

    }
}
