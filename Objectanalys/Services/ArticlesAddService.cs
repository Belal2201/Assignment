using Objectanalys.Models.Entities;
using Objectanalys.Repositories;

namespace Objectanalys.Services
{
    public class ArticlesAddService
    {
        private readonly ArticleRepository _articleRepository;

        public ArticlesAddService(ArticleRepository articleRepository)
        {
            _articleRepository = articleRepository;
        }

        public void CreateArticle(ArticleEntity article)
        {
            ArticleEntity articleRemade = article;


            _articleRepository.CreateArticleAsync(articleRemade);
        }
    }
}
