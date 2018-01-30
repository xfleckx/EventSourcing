namespace EventSourcedInvoice.DomainModel
{
    public interface IInvoiceRepository
    {
        InvoiceProcess GetByID(int id);
    }
}
