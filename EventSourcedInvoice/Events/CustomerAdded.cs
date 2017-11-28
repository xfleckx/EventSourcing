using EventSourcedInvoice.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventSourcedInvoice
{
    public class CustomerAdded : ADomainEvent
    {
        public string Name { get; set; }

        public CustomerAdded(string name, DateTime timeStamp)
        {
            TimeStamp = timeStamp;
            Name = name;
        }
    }
}
