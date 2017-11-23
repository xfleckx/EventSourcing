using System;
using EventSourcing.DomainEvents;

namespace EventSourcing
{
    public abstract class ACommand<E> : ICommand<E>
    {
        public event Action<E> CommandSuccessfullApplied;

        public abstract void Execute();

        public abstract bool Validate(Action<string> ValidationFailed);

        protected void Raise(E e)
        {
            CommandSuccessfullApplied?.Invoke(e);
        }
    }
}
