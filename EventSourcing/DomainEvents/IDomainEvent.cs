using System;

namespace EventSourcing.DomainEvents
{
    public interface IDomainEvent
    {
        Guid Guid { get; }
    }
}