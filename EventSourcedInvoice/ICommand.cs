namespace EventSourcedInvoice
{
    public interface ICommand
    {
        void ApplyTo(InvoiceProcess state);
    }
}