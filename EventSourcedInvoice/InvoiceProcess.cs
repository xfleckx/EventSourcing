using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using Newtonsoft.Json;
using EventSourcedInvoice.Commands;
using EventSourcedInvoice.Events;

namespace EventSourcedInvoice
{
    public class InvoiceProcess
    {
        private ICollection<Type> availableCommands = new List<Type>();
        
        [JsonProperty]
        private Queue<ADomainEvent> protocol = new Queue<ADomainEvent>();

        public InvoiceProcess()
        {
            availableCommands.Add(typeof(CreateInvoice));
        }

        public T Get<T>() where T : class, new()
        {
            var expectedType = typeof(T);
            try
            {
                var targetType = availableCommands.Single(t => t == expectedType);
            }
            catch (Exception)
            {
                throw new InvalidOperationException($"Command: {expectedType.Name} not available at this state of the object.");
            }

            return new T();
        }

        public void ReplayAllEvents()
        {
            var oldProtocol = new Queue<object>(protocol);

            protocol.Clear();
            
            foreach (var item in oldProtocol)
            {
                var expectedType = item.GetType();

                var commandType = expectedType;

                var command = Activator.CreateInstance(commandType, item);

                if(command is ICommand)
                    (command as ICommand).ApplyTo(this);
            }
        }

        internal void Append(ADomainEvent newEvent)
        {
            protocol.Enqueue(newEvent);
            
            // this should be an extra class defining the possible routes based on the use cases / business rules
            if(newEvent is InvoiceCreated && string.IsNullOrEmpty(Customer))
            {
                AllowCommand<AddCustomer>();
                DenyCommand<CreateInvoice>();
            }
            
        }

        private void DenyCommand<T>()
        {
            var expectedType = typeof(T);

            if (!availableCommands.Any(t => t == expectedType))
                availableCommands.Remove(expectedType);
        }

        private void AllowCommand<T>()
        {
            var expectedType = typeof(T);

            if (!availableCommands.Any(t => t == expectedType))
                availableCommands.Add(expectedType);
        }

        private JsonSerializerSettings serializerSettîng = new JsonSerializerSettings() {
            TypeNameHandling = TypeNameHandling.Objects,
            Formatting = Formatting.Indented
        };

        public int ID { get; set; }

        public string Customer { get; set; }
        
        public void PersistTo(FileInfo targetFile)
        {
            using (var writer = new StreamWriter(targetFile.FullName))
            {
                var binder = new KnownTypesBinder() {

                    KnownTypes = protocol.Select(i => i.GetType()).ToList()
                };

                binder.KnownTypes.Add(typeof(InvoiceProcess));

                serializerSettîng.SerializationBinder = binder;

                serializerSettîng.TypeNameHandling = TypeNameHandling.Objects;

                var protocolAsJson = JsonConvert.SerializeObject(this, serializerSettîng);

                writer.Write(protocolAsJson);
            }
        }

        public static InvoiceProcess LoadFrom(FileInfo targetFile)
        {
            var serializerSettîng = new JsonSerializerSettings();

            serializerSettîng.TypeNameHandling = TypeNameHandling.Objects;

            serializerSettîng.SerializationBinder = new KnownTypesBinder()
            {
                KnownTypes = new List<Type>() { typeof(InvoiceProcess), typeof(CustomerAdded), typeof(InvoiceCreated) }
            };

            using (var reader = new StreamReader(targetFile.FullName))
            {
                return JsonConvert.DeserializeObject<InvoiceProcess>(reader.ReadToEnd(), serializerSettîng);
            }
        }
        
    }
}
