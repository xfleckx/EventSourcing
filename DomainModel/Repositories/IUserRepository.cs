using DomainModel.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Repositories
{
    public interface IUserRepository : IRepository<User>
    {
        bool NameAvailable(string text);

        bool NickAvailable(string text);
    }
}
