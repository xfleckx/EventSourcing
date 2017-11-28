using System;

namespace EventSourcedInvoice.Events
{
    public abstract class ADomainEvent
    {
        public DateTime TimeStamp { get; set; }
    }
}