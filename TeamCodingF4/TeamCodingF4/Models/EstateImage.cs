using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace TeamCodingF4.Models
{
    public class EstateImage
    {
        public int ImageId { get; set; }

        public string ImagePath { get; set; }

    }
}
