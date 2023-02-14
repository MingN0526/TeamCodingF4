namespace TeamCodingF4.Models.ApiModel
{
    public class ArticleReplyModel
    {
        public int Id { get; set; }
        public int ArticleId { get; set; }
        public string Content { get; set; }
        public int PublisherId { get; set; }
        public string Date { get; set; }
    }
}
