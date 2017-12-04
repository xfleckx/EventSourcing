using EventSourcedInvoice.DomainModel;
using EventSourcedInvoice.Events;
using System;
using System.Linq;

namespace EventSourcedInvoice.Commands
{
    public class AddItem : ACommand
    {
        public InvoiceItem ItemToBeAdded { get; set; }

        public AddItem()
        {

        }

        public AddItem(ItemAdded fromEvent)
        {
            ItemToBeAdded = fromEvent.Item;
        }

        public override void ApplyTo(InvoiceProcess state)
        {
            if(!isReplay)
                state.Items.Add(ItemToBeAdded);

            var evt = new ItemAdded();

            evt.TimeStamp = DateTime.Now;

            evt.Item = ItemToBeAdded;

            // Calculate somthing based on the changes 
            // might be out of scope!?
            // for simple cases the aggregates state could be updated from the command
            // better -> use event handler!
            state.Brutto = state.Items.Sum(i => i.Brutto);
            
            if(!isReplay)
                state.Append(evt);
        }
    }
}
