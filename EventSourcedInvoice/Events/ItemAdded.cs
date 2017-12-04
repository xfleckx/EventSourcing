using EventSourcedInvoice.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventSourcedInvoice.Events
{
    public class ItemAdded : ADomainEvent
    {
        public InvoiceItem Item { get; set; }
    }
}
