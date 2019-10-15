using Microsoft.EntityFrameworkCore;

namespace APITest.Data
{
    public class DContext : DbContext
    {
        public DContext(DbContextOptions<DContext> options)
            : base(options)
        { }

        public DbSet<MyData> MyDatas { get; set; }
    }
}
