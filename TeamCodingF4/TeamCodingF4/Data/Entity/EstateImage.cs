using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeamCodingF4.Data.Entity
{
    public class EstateImage
    {
        [Key]
        public int ImageId { get; set; }

        [ForeignKey("Estate")]
        public int EstateId { get; set; }
        public string ImagePath { get; set; }
        public virtual Estate Estate { get; set; }
    }
}
