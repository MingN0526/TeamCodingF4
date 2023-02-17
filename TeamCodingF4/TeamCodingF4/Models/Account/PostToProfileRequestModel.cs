using System.ComponentModel.DataAnnotations;

namespace TeamCodingF4.Models.Account
{
    public class PostToProfileRequestModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string? Phone { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        public string? Identity { get; set; }
     
        public string BirthDate { get; set; }

        public int? Gender { get; set; }

        public string? Job { get; set; }

        public string? PicturePath { get; set; }

        //public string Address { get; set; }
    }
}
