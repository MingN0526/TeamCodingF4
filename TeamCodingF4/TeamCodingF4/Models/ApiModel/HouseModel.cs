using System.ComponentModel.DataAnnotations.Schema;
using TeamCodingF4.Data.Entity;

namespace TeamCodingF4.Models.ApiModel
{
    public class HouseModel
    {
        public int Id { get; set; }
        public string Tittle { get; set; }
  
        public int RoomTypeId { get; set; }

        public int Room { get; set; }
        public int hall { get; set; }
        public int bathroom { get; set; }

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
        public string? message { get; set; }

        public virtual ICollection<Equipment> Equipment { get; set; }
        public virtual ICollection<Condition> Conditions { get; set; }
        public virtual RoomType RoomType { get; set; }
        public virtual ICollection<EstateImage> EstateImage { get; set; }
    }
}
