using Infrastructure.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class PPMEFCoreRepositoryBase : IRepositoryBase
    {
        ModelDbContext _modelDbContext;

        public PPMEFCoreRepositoryBase(ModelDbContext modelDbContext)
        {
            _modelDbContext = modelDbContext;
        }

        public List<TEntity> GetAll<TEntity>() where TEntity : class
        {
            return _modelDbContext.Set<TEntity>().ToList();
        }
    }
}
