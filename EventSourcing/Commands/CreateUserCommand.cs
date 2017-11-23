using System;
using DomainModel.Repositories;
using EventSourcing.DomainEvents;

namespace EventSourcing.Commands
{
    public class CreateUserCommand : ACommand<UserCreatedEvent>
    {
        private IUserRepository repository;

        private string name;
        public string Name { get => name; set => name = value; }

        private string nick;
        public string Nick { get => nick; set => nick = value; }

        private Guid guid;
        public Guid Guid { get => guid; set => guid = value; }

        public CreateUserCommand(IUserRepository repository)
        {
            this.repository = repository;
        }


        public override void Execute()
        {
            var createdEvent = new UserCreatedEvent(Name, Nick, Guid);

            Raise(createdEvent);
        }

        public override bool Validate(Action<string> ValidationFailed)
        {
            if (!repository.NameAvailable(name))
            {
                ValidationFailed?.Invoke("Name already exists");

                return false;
            }
            
            if (!repository.NickAvailable(nick))
            {
                ValidationFailed?.Invoke("Nick already exists");

                return false;
            }

            return true;
        }
    }
}
