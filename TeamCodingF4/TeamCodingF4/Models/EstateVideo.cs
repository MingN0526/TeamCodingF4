using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace TeamCodingF4.Models
{
    public class EstateVideo
    {
        public int VideoId { get; set; }
        public string VideoPath { get; set; }
    }
}
