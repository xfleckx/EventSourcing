using System;

namespace EventSourcedInvoice
{
    public class AddCustomer : ICommand
    {
        public string CustomersName { get; set; }

        public AddCustomer()
        {

        }

        public AddCustomer(CustomerAdded fromEvent)
        {
            CustomersName = fromEvent.Name;
        }

        public void ApplyTo(InvoiceProcess state)
        {
            state.Customer = CustomersName;

            state.Append(new CustomerAdded(CustomersName, DateTime.Now));
        }
    }
}
