using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TeamCodingF4.Data;
using TeamCodingF4.Models.ApiModel;

namespace TeamCodingF4.Controllers.Api
{
    [Route("api/GetNewestArticle/[action]")]
    [ApiController]
    public class GetNewestArticleApiController : ControllerBase
    {
        private readonly ApplicationDbContext _db;

        public GetNewestArticleApiController(ApplicationDbContext data)
        {
            _db = data;
        }
        //public List<ArticleModel> GetAll()
        //{
            
        //    return _db.Articles.Select(x=>new ArticleModel
        //    {
        //       NewestArticleTitle = x.Title
        //    }).ToList();
        //}

    }
}
