using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventStore.ClientAPI;
using Newtonsoft.Json;
using EventSourcing.DomainEvents;

namespace EventSourcing
{
    public abstract class ACommand<E> : ICommand<E> where E : IDomainEvent
    {
        public event Action<E> OnCommandSuccessfullApplied;

        public abstract void Execute();

        protected void Raise(E e)
        {
            OnCommandSuccessfullApplied?.Invoke(e);
        }
    }
}
