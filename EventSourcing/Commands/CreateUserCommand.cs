using System;
using EventSourcing.DomainEvents;

namespace EventSourcing.Commands
{
    public class CreateUserCommand : ACommand<UserCreatedEvent>
    {
        private string text;
        private Guid guid;

        public CreateUserCommand(string text, Guid guid)
        {
            this.text = text;
            this.guid = guid;
        }

        public override void Execute()
        {
            var createdEvent = new UserCreatedEvent(text, guid);

            Raise(createdEvent);
        }
    }
}
