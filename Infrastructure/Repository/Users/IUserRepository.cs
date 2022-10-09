using Infrastructure.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository.Users
{
    public interface IUserRepository : IRepositoryBase
    {
        public List<User> GetAllUser();
    }
}
