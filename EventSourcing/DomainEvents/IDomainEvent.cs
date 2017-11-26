using System;

namespace EventSourcing.DomainEvents
{
    public interface IDomainEvent
    {
        Guid Guid { get; }

        string EventTypeName { get; }

        string DomainStreamName { get; }
    }
}