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
        public int AirConditioner { get; set; }
        public int Television { get; set; }
        public int WetDry { get; set; }
        public int Balcony { get; set; }
        public int WashingMachine { get; set; }
        public int WaterDispenser { get; set; }
        public int Refrigerator { get; set; }
        public string Lease { get; set; }
        public string EstatePicture { get; set; }
        public string EstateVideo { get; set; }
        public string message { get; set; }

    }
}
