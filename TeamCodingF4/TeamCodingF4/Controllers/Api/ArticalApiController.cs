using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TeamCodingF4.Data;
using TeamCodingF4.Models.ApiModel;

namespace TeamCodingF4.Controllers.Api
{
    [Route("api/artical/[action]")]
    [ApiController]
    public class ArticalApiController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        public ArticalApiController(ApplicationDbContext context)
        {
            _db = context;
        }
        public List<ArticalModel> GetAll()
        {
            return _db.Articals.Select(x=> new ArticalModel
            {
                ArticalDate=x.ArticalDate,
                ArticleContent=x.ArticleContent,
                ArticlePublisher=x.ArticlePublisher,
                ArticleTitle=x.ArticleTitle,
            }).ToList();
        }
    }
}
