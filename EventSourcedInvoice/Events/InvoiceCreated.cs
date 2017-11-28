using System;

namespace EventSourcedInvoice.Events
{
    public class InvoiceCreated : ADomainEvent
    {
        private int newID;

        public InvoiceCreated()
        {

        }

        public InvoiceCreated(int newID, DateTime dateTime)
        {
            this.NewID = newID;
            this.TimeStamp = dateTime;
        }

        public int NewID { get => newID; private set => newID = value; }
    }
}
