using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using TeamCodingF4.Data;
using TeamCodingF4.Data.Entity;
using TeamCodingF4.Extension;
using TeamCodingF4.Models;
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
            return _db.Articles.Select(x => new ArticleModel
            {
                Id = x.ArticleId,
                Content = x.Content,
                Date = x.Date.ToString("d"),
                Title = x.Title,
                ViewCount = x.ViewCount,
                Category = x.Category,
                PublisherId = x.PublisherId,
                ReplyId = x.ReplyId
            }).ToList();
        }

        [HttpPost]
        public async Task<ApiResultModel> PostArticle(ArticleInsertModel model)
        {
            //var memberId = User.Claims.GetMemberId();
            //var articleId = User.Claims.GetArticleId();
            Articles articles = new Articles
            {
                Title = model.Title,
                Content = model.Content,
                Category = model.Category,
                Date = DateTime.UtcNow,
                ViewCount = 1,  //TODO Viewcount function
                //PublisherId = memberId, TODO
                PublisherId = 1,                                    
            };
            _db.Articles.Add(articles);
            await _db.SaveChangesAsync();            
            return new ApiResultModel
            {
                Status = true,
                Message = "加入成功"
            };
           
        }

        //public async Task<Articles> GetId(int id)
        //{
        //    var articleId = _db.Articles.FirstOrDefault(x => x.ArticleId == id);
        //    if (articleId == null)
        //    {
        //        return null;
        //    }
        //    return articleId;
        //}



        [HttpPost]
        public async Task<ApiResultModel> DeleteArticle([FromBody] int id)
        {
            Articles articles = await _db.Articles.FindAsync(id);
            if (articles != null)
            {
                var replies =_db.ArticlesReply.Where(x => x.ArticleId == id).ToList();
                _db.ArticlesReply.RemoveRange(replies);
                _db.Articles.Remove(articles);
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


//<<<<<<< HEAD
//        //[HttpPost]
//=======
//        [HttpPost]
//>>>>>>> a2557c02216421889a8e3dad4d97cb2b821a4c66
//        //public async Task<ApiResultModel> EditArticle([FromBody] ArticleModel articleModel)
//        //{
//        //    if (id != articleModel.Id)
//        //    {
//        //        return null;
//        //    }
//        //    Articles articles = await _db.Articles.FindAsync(articleModel.Id);
//        //    articles.Content = articleModel.Content;
//        //    articles.Title = articleModel.Title;
//        //    articles.Category = articleModel.Category;
//        //    _db.Entry(articles).State = EntityState.Modified;
//        //    try
//        //    {
//        //        await _db.SaveChangesAsync();
//        //    }
//        //    catch (DbUpdateConcurrencyException)
//        //    {
//        //        if (!ArticleExists(id))
//        //        {
//        //            return new ApiResultModel
//        //            {
//        //                Status = false,
//        //                Message = "找不到需編輯的文章"
//        //            };
//        //        }
//        //        else
//        //        {
//        //            throw;
//        //        }
//        //    }
//        //    return new ApiResultModel
//        //    {
//        //        Status = true,
//        //        Message = "編輯成功"
//        //    };
        //}

        private bool ArticleExists(int id)
        {
            return _db.Articles.Any(x => x.ArticleId == id);
        }
    }
}
