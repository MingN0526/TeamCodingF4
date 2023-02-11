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
        public async Task<ApiResultModel> PostArticleReply(ArticleReplyInsertModel model)
        {
            
            ArticleReply articlesReply = new ArticleReply
            {
                PublisherId= 1,
                ArticleId= 1,
                Content= model.Content,
                Date= DateTime.Now
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
        [HttpPost("{id}")]
        //[ValidateAntiForgeryToken]
        public async Task<ApiResultModel> DeleteArticleReply([FromBody] Int32 id)
        {
            ArticleReply articlesReply = await _db.ArticlesReply.FindAsync(id);
            if (articlesReply != null)
            {
                _db.ArticlesReply.Remove(articlesReply);
                await _db.SaveChangesAsync();
                return new ApiResultModel
                {
                    Status = true,
                    Message = "刪除成功"
                };
            }

            return new ApiResultModel
            {
                Status = false,
                Message = "刪除失敗"
            };
        }
    }
}
