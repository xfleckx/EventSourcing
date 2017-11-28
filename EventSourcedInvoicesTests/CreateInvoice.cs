using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EventSourcedInvoice;

namespace EventSourcedInvoicesTests
{
    [TestClass]
    public class CreateInvoice
    {
        [TestMethod]
        public void CreateInvoiceWithId()
        {
            var state = new InvoiceProcess();

            var createInvoiceCommand = state.Get<EventSourcedInvoice.Commands.CreateInvoice>();
            
            createInvoiceCommand.NewID = 123;

            createInvoiceCommand.ApplyTo(state);
            
            state.PersistTo(new System.IO.FileInfo("test.json"));
        }


        [TestMethod]
        public void LoadInvoiceFromFile()
        {
            var state = InvoiceProcess.LoadFrom(new System.IO.FileInfo("test.json"));

            state.ReplayAllEvents();

            Equals(state.ID == 123);
        }

        [TestMethod]
        public void AddCustomerToInvoice()
        {
            var state = InvoiceProcess.LoadFrom(new System.IO.FileInfo("test.json"));
            
            state.ReplayAllEvents();

            var command = state.Get<AddCustomer>();

            command.CustomersName = "Bob";
            command.ApplyTo(state); 

            state.PersistTo(new System.IO.FileInfo("testCustomer.json"));
        }
        
        [TestMethod]
        public void LoadInvoiceWithUserFromFile()
        {
            var state = InvoiceProcess.LoadFrom(new System.IO.FileInfo("testCustomer.json"));

            Assert.IsTrue(state.ID == 123, "ID missmatch");
            Assert.IsTrue(state.Customer == "Bob", "Customer missmatch");
        }
    }
}
