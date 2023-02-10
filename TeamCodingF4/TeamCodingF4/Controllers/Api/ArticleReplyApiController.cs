using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TeamCodingF4.Data;
using TeamCodingF4.Models.ApiModel;

namespace TeamCodingF4.Controllers.Api
{
    [Route("api/ArticleReply/[action]")]
    [ApiController]
    public class ArticleReplyApiController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        public ArticleReplyApiController(ApplicationDbContext context)
        {
            _db = context;
        }
        public List<ArticleReplyModel> GetAllReply()
        {
            return _db.Articles.Select(x => new ArticleReplyModel
            {
                Id = x.ReplyId,
                PublisherId = x.PublisherId,
                Content = x.Content,
                Date = DateTime.Now,
                ArticleId = x.ArticleId,                
            }).ToList();
        }
    }
}
