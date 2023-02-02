using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TeamCodingF4.Data;
using TeamCodingF4.Models.ApiModel;

namespace TeamCodingF4.Controllers.Api
{
    [Route("api/article/[action]")]
    [ApiController]
    public class ArticleApiController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        public ArticleApiController(ApplicationDbContext context)
        {
            _db = context;
        }
        public List<ArticleModel> GetAll()
        {
            return _db.Articles.Select(x=> new ArticleModel
            {
                ArticleId = x.ArticleId,
                ArticleDate=x.Date,
                ArticleContent=x.Content,
                ArticlePublisher=x.Publisher,
                ArticleTitle=x.Title,
                ArticleCategory=x.Category
            }).ToList();
        }
    }
}
