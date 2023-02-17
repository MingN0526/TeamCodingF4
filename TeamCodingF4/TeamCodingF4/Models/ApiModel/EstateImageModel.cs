using System.ComponentModel.DataAnnotations.Schema;
using TeamCodingF4.Data.Entity;

namespace TeamCodingF4.Models.ApiModel
{
    public class EstateImageModel
    {
        public int ImageId { get; set; }
        public int EstateId { get; set; }
        public string ImagePath { get; set; }
    
    }
}
