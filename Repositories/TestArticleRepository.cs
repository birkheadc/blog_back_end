using Blog.Entities;

namespace Blog.Repositories
{
    public class TestArticleRepository : IArticleRepository
    {
        private readonly List<Article> articles = new()
        {
            new Article
            {
                Id = Guid.NewGuid(),
                PostDate = DateTimeOffset.UtcNow,
                Title = "First Blog Post",
                Body = "This is the first blog post and here is some text."
            },
            new Article
            {
                Id = Guid.NewGuid(),
                PostDate = DateTimeOffset.UtcNow,
                Title = "Second Blog Post",
                Body = "This is the second blog post and here is some text and a bit more so that it looks different."
            },
            new Article
            {
                Id = Guid.NewGuid(),
                PostDate = DateTimeOffset.UtcNow,
                Title = "Third Blog Post",
                Body = "This is the third blog post and here is some text.\nAlso here is a newline probably?\nThe end."
            }
        };

        public IEnumerable<Article> GetArticles()
        {
            return articles;
        }

        public Article GetArticleById(Guid id)
        {
            Article article;

            try
            {
                article = this.articles.Where(article => article.Id == id).Single();
            }
            catch
            {
                return new Article()
                {
                    Id = Guid.Empty,
                    PostDate = DateTimeOffset.MinValue,
                    Title = "404",
                    Subtitle = "This article does not exist.",
                    Body = "You've somehow attempted to retrieve an article that doesn't exist!"
                };
            }      
            
            return article;
        }

        public Article GetArticleByTitle(string title)
        {
            Article article;

            try
            {
                article = this.articles.Where(article => article.Title == title).First();
            }
            catch
            {
                return new Article()
                {
                    Id = Guid.Empty,
                    PostDate = DateTimeOffset.MinValue,
                    Title = "404",
                    Subtitle = "This article does not exist.",
                    Body = "You've somehow attempted to retrieve an article that doesn't exist!"
                };
            }      
            
            return article;
        }
    }
}