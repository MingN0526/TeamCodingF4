namespace TeamCodingF4.Models
{
    public class UploadModel
    {
        public List<IFormFile> files { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
    }
}
