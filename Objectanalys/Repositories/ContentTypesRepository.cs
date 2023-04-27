using Objectanalys.Contexts;

namespace Objectanalys.Repositories
{
    public class ContentTypesRepository
    {
        private readonly DataContext _dataContext;

        public ContentTypesRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
    }
}
