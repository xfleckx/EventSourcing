using EventSourcing.DomainEvents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventStore.ClientAPI;

namespace EventSourcing.Reactors
{
    public class CounterReactor<T> : AReactor where T : ADomainEvent
    {
        private int eventCount = 0;

        public int EventCount { get => eventCount; }

        public event Action<int> CountChanged;

        public void AttachToStream()
        {
            connection.SubscribeToStreamAsync(typeof(T).Name, false, HandleEvent);
        }

        private Task HandleEvent(EventStoreSubscription subscription, ResolvedEvent resolvedEvent)
        {
            var domainEvent = DecodeEvent<T>(resolvedEvent.OriginalEvent.Data);

            return Task.Factory.StartNew(Process);
        }

        private void Process()
        {
            eventCount++;

            CountChanged?.Invoke(eventCount);
        }
    }
}
