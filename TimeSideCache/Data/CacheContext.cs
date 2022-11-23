using Microsoft.EntityFrameworkCore;

namespace TimeSideCache.Data
{
    public class CacheContext : DbContext
    {

        public CacheContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<CacheData> CacheDatas { get; set; }
    }
}
