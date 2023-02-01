using System.ComponentModel.DataAnnotations;

namespace TeamCodingF4.Models
{
    public class EstateModel
    {
        [Key]
        public int EstateId { get; set; }

        [Required(ErrorMessage = "請輸入標題")]
        public string EstateTittle { get; set; }

        [Required(ErrorMessage = "請選擇房型")]
        public string RoomType { get; set; }

        [Required(ErrorMessage = "請輸入地址")]
        public string Address { get; set; }

        [Required(ErrorMessage = "請輸入價格")]
        public string EststePrice { get; set; }

        [Required(ErrorMessage = "請輸入雜費")]
        public string Miscellaneous { get; set; }

        [Required(ErrorMessage = "請輸入坪數")]
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

        [Required(ErrorMessage = "請輸入租約期")]
        public string Lease { get; set; }

        [Required(ErrorMessage = "請選擇圖片")]
        public List<IFormFile> EstatePicture { get; set; }

        public IFormFile EstateVideo { get; set; }
        public string? message { get; set; }

    }
}
