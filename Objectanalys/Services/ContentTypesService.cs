using Objectanalys.Contexts;
using Objectanalys.Models.Entities;

namespace Objectanalys.Services
{
    public class ContentTypesService
    {
        private readonly DataContext _dataContext;

        public ContentTypesService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }


        public async Task<bool> CreateContentTypesAsync(ContentTypeEntity type)
        {
            try
            {
                _dataContext.Add(type);
                await _dataContext.SaveChangesAsync();
                return true;
            }
            catch { return false; }
        }


    }
}
