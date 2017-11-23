using System;

namespace EventSourcing.DomainEvents
{
    public class UserCreatedEvent : ADomainEvent
    {
        private string name;

        private string nick;

        private Guid userId;


        public UserCreatedEvent(string name, string nick, Guid guid)
        {
            this.Name = name;
            this.Nick = nick;
            this.UserId = guid;
        }

        public string Nick { get => nick; set => nick = value; }
        
        public string Name { get => name; set => name = value; }
        public Guid UserId { get => userId; set => userId = value; }
    }
}
