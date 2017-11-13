using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BaseApplication.Models;
using BaseApplicationEntities;
using BaseApplicationEntities.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BaseApplication.Controllers
{
    [Produces("application/json")]
    [Route("api/articles")]
    public class ArticleController : Controller
    {
        private readonly BaseAppContext _baseAppContext;

        public ArticleController(BaseAppContext baseAppContext)
        {
            _baseAppContext = baseAppContext;
        }

        [HttpGet]
        public  IEnumerable<Article> List(int limit, int offset, string tag, string author, string favorited)
        {
            var result = _baseAppContext.Articles.ToArray();

            return result;
        }

        [HttpPost]
        public string Add([FromBody] ArticleModel articleModel)
        {
            _baseAppContext.Add(new Article
            {
                Body = articleModel.Body,
                CreatedAt = articleModel.CreatedAt,
                Description = articleModel.Description,
                Slug = articleModel.Slug,
                Title = articleModel.Title,
                UpdatedAt = articleModel.UpdatedAt
            });

            _baseAppContext.SaveChanges();

            return string.Empty;
        }
    }
}