using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TeamCodingF4.Data;
using TeamCodingF4.Data.Entity;
using TeamCodingF4.Models.ApiModel;

namespace TeamCodingF4.Controllers.Api
{
    [Route("api/articlereply/[action]")]
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
            return _db.ArticlesReply.Select(x => new ArticleReplyModel
            {
                ArticleId = x.ArticleId,
                Id= x.Id,
                Date= x.Date,
                Content= x.Content,
                PublisherId= x.PublisherId,
            }).ToList();
        }
        [HttpPost]
        public async Task<ApiResultModel> PostArticle(ArticleReplyInsertModel model)
        {
            
            ArticleReply articlesReply = new ArticleReply
            {
                PublisherId= model.PublisherId,
                ArticleId= model.ArticleId,
                Content= model.Content,
                Date= model.Date,
            };
            _db.ArticlesReply.Add(articlesReply);
            await _db.SaveChangesAsync();

            return new ApiResultModel
            {
                Status = true,
                Message = "加入成功"
            };
            return new ApiResultModel
            {
                Status = false,
                Message = "加入失敗"
            };
        }
    }
}
