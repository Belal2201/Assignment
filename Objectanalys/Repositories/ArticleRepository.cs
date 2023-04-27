using Objectanalys.Contexts;
using Objectanalys.Models.Entities;

namespace Objectanalys.Repositories
{
    public class ArticleRepository
    {
        private readonly DataContext _dataContext;

        public ArticleRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<bool> CreateArticleAsync(ArticleEntity article)
        {
            try
            {
                _dataContext.Add(article);
                await _dataContext.SaveChangesAsync();
                return true;
            }
            catch { return false; }
        }
    }
}
