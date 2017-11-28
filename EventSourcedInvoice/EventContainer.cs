using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventSourcedInvoice
{
    public class EventContainer
    {
        private object newEvent;

        public EventContainer(object newEvent)
        {
            this.newEvent = newEvent;
        }

        public string TypeName { get; set; }
        public object ActualEvent { get; set; }
    }
}
