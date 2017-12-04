using EventSourcedInvoice.DomainModel;

namespace EventSourcedInvoice
{
    public interface ICommand
    {
        void ApplyTo(InvoiceProcess state);
    }
}