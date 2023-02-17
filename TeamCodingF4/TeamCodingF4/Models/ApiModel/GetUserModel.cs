using System.ComponentModel.DataAnnotations;

namespace TeamCodingF4.Models.ApiModel
{
    public class GetUserModel
                    //        Id: "",
                    //Email: "",
                    //Name: "",
                    //Gender: "",
                    //BirthDate: "",
                    //Identity: "",
                    //Job: "",
                    //Phone: "",
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string? Phone { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        public string? Identity { get; set; }

        public int? Gender { get; set; }

        public string? Job { get; set; }

        public string? PicturePath { get; set; }
    }
}
