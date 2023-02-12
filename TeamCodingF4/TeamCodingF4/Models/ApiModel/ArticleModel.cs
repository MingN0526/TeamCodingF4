namespace TeamCodingF4.Models.ApiModel
{
    public class ArticleModel
    {
        public int Id { get; set; }
        public string Date { get; set; }
        public int PublisherId { get; set; }
        public string Content { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
        public int ViewCount { get; set; }
        public int ReplyId { get; set; }
    }
}
