using Infrastructure.Model;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.EntityFrameworkCore
{
    public class ModelDbContext: DbContext
    {
        public ModelDbContext()
        {

        }

        public ModelDbContext(DbContextOptions<ModelDbContext> options)
            : base(options)
        {
        }



        public virtual DbSet<User> User { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }
    }
}
