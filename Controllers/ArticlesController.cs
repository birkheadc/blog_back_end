using Microsoft.AspNetCore.Mvc;
using Blog.Repositories;
using Blog.Entities;

namespace Blog.Controllers
{
    [ApiController]
    [Route("api/articles")]
    public class ArticlesController : ControllerBase
    {
        private readonly IArticleRepository repository;

        public ArticlesController(IArticleRepository repository)
        {
            this.repository = repository;
        }

        [HttpGet]
        public IEnumerable<Article> GetArticles()
        {
            IEnumerable<Article> articles = repository.GetArticles();
            return articles;
        }

        [HttpGet("/id/{id}")]
        public Article GetArticleById(Guid id)
        {
            Article article = repository.GetArticleById(id);
            return article;
        }

        [HttpGet("/title/{title}")]
        public Article GetArticleByTitle(string title) 
        {
            Article article = repository.GetArticleByTitle(title);
            return article;
        }
        
    }
}