using System;

namespace DomainModel.Users
{
    interface IUserRepository
    {
        User GetByID(Guid guid);

        User GetByNick(string nickName);
    }
}
