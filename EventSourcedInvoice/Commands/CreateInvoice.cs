using EventSourcedInvoice.DomainModel;
using EventSourcedInvoice.Events;
using System;

namespace EventSourcedInvoice.Commands
{
    public class CreateInvoice : ACommand
    {
        public int NewID { get; set; }
        
        public CreateInvoice()
        {
            isReplay = false;
        }

        public CreateInvoice(InvoiceCreated fromEvent)
        {
            NewID = fromEvent.NewID;
            isReplay = true;
        }

        public override void ApplyTo(InvoiceProcess state)
        {
            state.ID = NewID;
            
            if(!isReplay)
                state.Append(new InvoiceCreated(NewID, DateTime.Now));
        }
    }
}
