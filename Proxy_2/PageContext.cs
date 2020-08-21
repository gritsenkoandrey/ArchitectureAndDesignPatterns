using System.Data.Entity;


namespace Proxy_2
{
    public class PageContext : DbContext
    {
        public DbSet<Page> Pages { get; set; }
    }
}