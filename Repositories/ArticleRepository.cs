using Blog.Entities;

namespace Blog.Repositories
{
    public interface ArticleRepository
    {
        public IEnumerable<Article> GetArticles();
        public Article GetArticleById(Guid id);

        public Article GetArticleByTitle(string title);
    }
}