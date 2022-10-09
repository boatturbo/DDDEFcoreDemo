using Infrastructure.EntityFrameworkCore;
using Infrastructure.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository.Users
{
    public class UserRepository : PPMEFCoreRepositoryBase, IUserRepository
    {
        public UserRepository(ModelDbContext modelDbContext) : base(modelDbContext)
        {

        }

        public List<User> GetAllUser()
        {
            return base.GetAll<User>();
        }
    }
}
