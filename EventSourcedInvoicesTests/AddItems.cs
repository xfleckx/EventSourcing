using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EventSourcedInvoice.DomainModel;
using EventSourcedInvoice.Commands;

namespace EventSourcedInvoicesTests
{
    [TestClass]
    public class AddItems
    {
        [TestMethod]
        public void AddSingleItemToInvoice()
        {
            var state = InvoiceProcess.LoadFrom(new System.IO.FileInfo("testCustomer.json"));

            var item = new InvoiceItem
            {
                Brutto = 0.5f,
                Name = "A demo item",
                Description = "A long description"
            };

            var addItem = new AddItem();

            addItem.ItemToBeAdded = item;
            
            addItem.ApplyTo(state);

            var targetfile = new System.IO.FileInfo("invoiceOnItem.json");

            state.PersistTo(targetfile);

            state = InvoiceProcess.LoadFrom(targetfile);

            state.ReplayAllEvents();

            Assert.AreEqual(0.5f, state.Brutto);
        }
    }
}
