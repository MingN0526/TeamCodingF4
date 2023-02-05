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
                Date = DateTime.Now,
                Title = x.Title,
                ViewCount = x.ViewCount,
                Category = x.Category,
                PublisherId = x.PublisherId,
            }).ToList();
        }

       
        [HttpPost]
        public async Task<ApiResultModel> PostArticle(ArticleInsertModel model)
        {
            //var memberId = User.Claims.GetMemberId();
            Articles articles = new Articles
            {
                Title = model.Title,
                Content = model.Content,
                Category= model.Category,
                Date = DateTime.Now,
                ViewCount = 1,  //TODO Viewcount function
                //PublisherId = memberId, TODO
                PublisherId = 1,
            };          
            _db.Articles.Add(articles);
            await _db.SaveChangesAsync();

            return new ApiResultModel
            {
                Status=true,
                Message="加入成功"
            };
            return new ApiResultModel
            {
                Status = false,
                Message = "加入失敗"
            };
        }
       

        
        [HttpPost("{id}"), ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<string> DeleteArticle(int id)
        {
            Articles? articles = await _db.Articles.FindAsync(id);
            if (articles == null)
            {
                return "找不到欲刪除的紀錄!";
            }

            _db.Articles.Remove(articles);
            await _db.SaveChangesAsync();

            return "刪除成功!";
        }

        
        [HttpPut("{id}")]
        [ValidateAntiForgeryToken]
        public async Task<string> PutArticle(int id, ArticleModel articleModel)
        {
            if (id != articleModel.Id)
            {
                return null;
            }
            Articles? articles = await _db.Articles.FindAsync(articleModel.Id);
            articles.Content = articleModel.Content;
            articles.Title = articleModel.Title;
            _db.Entry(articles).State = EntityState.Modified;

            try
            {
                await _db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ArticleExists(id))
                {
                    return "找不到欲修改的紀錄!";
                }
                else
                {
                    throw;
                }
            }
            return "修改成功!";
        }

       
        [HttpGet]
        [ValidateAntiForgeryToken]
        public async Task<IEnumerable<ArticleModel>> GetArticle()
        {
            return _db.Articles.Select(
                articles => new ArticleModel
                {
                    Title = articles.Title,
                    Content = articles.Content,
                }).ToList();
        }

       
        [HttpGet("{id}")]
        public async Task<ArticleModel> GetArticle(int id)
        {
            var articleModel = _db.Articles.Where(articles => articles.ArticleId == id).Select(articles => new ArticleModel
            {
                Content = articles.Content,
                Title = articles.Title,
            }).FirstOrDefault();

            if (articleModel == null)
            {
                return null;
            }

            return articleModel;

        }

        //// POST: api/EmployeesDTOes/Filter
        //[HttpPost("Filter")]
        //public async Task<IEnumerable<ArticleModel>> filterArticles(ArticleModel articleModel)
        //{
        //    return _db.Articles.Where(emp => emp.FirstName.Contains(employeesDTO.FirstName)).Select(
        //    emp => new EmployeesDTO
        //    {
        //        EmployeeId = emp.EmployeeId,
        //        FirstName = emp.FirstName,
        //        LastName = emp.LastName,
        //        Title = emp.Title
        //    });
        //}
        private bool ArticleExists(int id)
        {
            return _db.Articles.Any(x => x.ArticleId == id);
        }
    }
}
