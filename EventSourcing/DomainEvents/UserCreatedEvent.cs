using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventSourcing.DomainEvents
{
    public class UserCreatedEvent : ADomainEvent
    {
        private string text;
        private Guid guid;

        public UserCreatedEvent(string text, Guid guid)
        {
            this.text = text;
            this.guid = guid;
        }
    }
}
