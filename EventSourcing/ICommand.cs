using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventStore.ClientAPI;

namespace EventSourcing
{
    public interface ICommand<TDomainEvent>
    {
        void Execute();
        event Action<TDomainEvent> OnCommandSuccessfullApplied;

    }
}
