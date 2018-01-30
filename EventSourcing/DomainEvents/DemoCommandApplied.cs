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

        public override string EventTypeName => throw new NotImplementedException();

        public override string DomainStreamName => throw new NotImplementedException();
    }
}
