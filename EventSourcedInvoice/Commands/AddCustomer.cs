using EventSourcedInvoice.Commands;
using EventSourcedInvoice.DomainModel;
using System;

namespace EventSourcedInvoice
{
    public class AddCustomer : ACommand
    {
        public string CustomersName { get; set; }

        public AddCustomer()
        {

        }

        public AddCustomer(CustomerAdded fromEvent)
        {
            isReplay = true;
            CustomersName = fromEvent.Name;
        }

        public override void ApplyTo(InvoiceProcess state)
        {
            state.Customer = CustomersName;

            var evt = new CustomerAdded(CustomersName, DateTime.Now);
            
            if(!isReplay)
                state.Append(evt);
        }
    }
}
