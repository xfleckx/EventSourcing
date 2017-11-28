namespace EventSourcedInvoice
{
    public class AddCustomer : ICommand
    {
        public string CustomersName { get; set; }

        public void ApplyTo(InvoiceProcess state)
        {
            state.Customer = CustomersName;
        }
    }
}
