using EventSourcedInvoice.Events;
using System;

namespace EventSourcedInvoice.Commands
{
    public class CreateInvoice : ICommand
    {
        public int NewID { get; set; }

        private readonly bool isReplay;

        public CreateInvoice()
        {
            isReplay = false;
        }

        public CreateInvoice(InvoiceCreated fromEvent)
        {
            NewID = fromEvent.NewID;
            isReplay = true;
        }

        public void ApplyTo(InvoiceProcess state)
        {
            state.ID = NewID;
            
            if(!isReplay)
                state.Append(new InvoiceCreated(NewID, DateTime.Now));
        }
    }
}
