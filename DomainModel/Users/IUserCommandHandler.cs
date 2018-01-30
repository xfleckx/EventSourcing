using DomainModel.Users.Commands;
    
namespace DomainModel.Users
{
    interface IUserCommandHandler
    {
        void Handle(AddUser command);

        void Handle(RemoveUser command);

        void Validated(AddUser command);

        void Validated(RemoveUser command);
    }
}
