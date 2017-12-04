using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventSourcedInvoice.DomainModel;

namespace EventSourcedInvoice.Commands
{
    public abstract class ACommand : ICommand
    {
        protected bool isReplay = false;

        public abstract void ApplyTo(InvoiceProcess state);
    }
}
