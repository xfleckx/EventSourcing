using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventSourcing.DomainEvents
{
    public class DemoCommandApplied : ADomainEvent
    {
        public string DomainMessage;

        public int DomainValue;

        public string DomainName;
    }
}
