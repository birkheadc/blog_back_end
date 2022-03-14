using Blog.Entities;

namespace Blog.Repositories
{
    public interface IArticleRepository
    {
        public IEnumerable<Article> GetArticles();
        public Article GetArticleById(Guid id);

        public Article GetArticleByTitle(string title);
    }
}