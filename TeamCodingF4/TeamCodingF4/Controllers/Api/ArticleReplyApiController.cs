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
        public List<ArticleReplyModel> GetReplyContent()
        {
            return _db.ArticlesReply.Select(x => new ArticleReplyModel
            {
                ReplyContent=x.ReplyContent,
                ReplyDate=x.ReplyDate,
                ReplyPublisher=x.ReplyPublisher
            }).ToList();
        }
    }
}
