
using System.Data.Entity;

namespace EF.Models
{
    public class DBContext : DbContext
    {
        public DbSet<ArticleCommonTable> ArticleCommonTables { get; set; }
        public DbSet<ArticleFirstTypeTable> ArticleFirstTypeTables { get; set; }
        public DbSet<ArticleSecondTypeTable> ArticleSecondTypeTables { get; set; }
    }
}
