using Microsoft.EntityFrameworkCore;

namespace Infrastructure.EntityFrameworkCore
{
    public class ModelDbContext<TDbContext>: DbContext
    {
        public ModelDbContext()
        {

        }

        public ModelDbContext(DbContextOptions<ModelDbContext<TDbContext>> options)
            : base(options)
        {
        }


    }
}
