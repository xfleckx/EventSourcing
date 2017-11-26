using System;

namespace EventSourcing.DomainEvents
{
    public abstract class ADomainEvent : IDomainEvent
    {
        private Guid guid;

        public Guid Guid
        {
            get
            {
                if (guid == null)
                    guid = Guid.NewGuid();

                return guid;
            }
        }

        public abstract string EventTypeName { get; }

        public abstract string DomainStreamName { get; }

        public DateTime Created { get; }
        
    }
}
