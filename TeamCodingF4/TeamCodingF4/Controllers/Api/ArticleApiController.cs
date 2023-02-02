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
                Id= x.Id,
                Content= x.Content,
                Date= DateTime.Now,
                Title= x.Title,
                ViewCount= x.ViewCount,
                Category= x.Category,
                PublisherId= x.PublisherId,
            }).ToList();
        }
    }
}
