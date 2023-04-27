using Microsoft.EntityFrameworkCore;
using Objectanalys.Models.Entities;

namespace Objectanalys.Contexts
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<ContentTypeEntity> ContentTypes { get; set; }
        public DbSet<ArticleEntity> Articles { get; set; }

    }
}
