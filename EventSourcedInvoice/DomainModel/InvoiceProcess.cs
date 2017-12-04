using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using Newtonsoft.Json;
using EventSourcedInvoice.Commands;
using EventSourcedInvoice.Events;

namespace EventSourcedInvoice.DomainModel
{
    public class InvoiceProcess
    {
        public static IDictionary<Type, Type> knownCommands = new Dictionary<Type, Type>()
        {
            { typeof(InvoiceCreated), typeof(CreateInvoice) },
            { typeof(CustomerAdded), typeof(AddCustomer) },
            { typeof(ItemAdded), typeof(AddItem) }
        };
        
        public int ID { get; set; }

        public string Customer { get; set; }

        [JsonProperty]
        public ICollection<InvoiceItem> Items { get; set; }
        public float Brutto { get; internal set; }

        private IList<Type> availableCommands = new List<Type>();
        
        [JsonProperty]
        private Queue<ADomainEvent> protocol = new Queue<ADomainEvent>();

        public InvoiceProcess()
        {
            Items = new List<InvoiceItem>();

        }

        public T Get<T>() where T : class, new()
        {
            var expectedType = typeof(T);
            try
            {
                var targetType = knownCommands.Values.Single(t => t == expectedType);
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

                var commandType = knownCommands[expectedType];

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

        private void AllowCommand<T>()
        {
            var expectedType = typeof(T);

            if (!availableCommands.Contains(expectedType))
                availableCommands.Add(expectedType);
        }

        private void DenyCommand<T>()
        {
            var expectedType = typeof(T);

            if (!availableCommands.Contains(expectedType))
                availableCommands.Remove(expectedType);
        }

        private JsonSerializerSettings serializerSettîng = new JsonSerializerSettings() {
            TypeNameHandling = TypeNameHandling.Objects,
            Formatting = Formatting.Indented
        };
        
        public void PersistTo(FileInfo targetFile)
        {
            using (var writer = new StreamWriter(targetFile.FullName))
            {
                KnownTypesBinder binder = CreateBinder();

                serializerSettîng.SerializationBinder = binder;

                serializerSettîng.TypeNameHandling = TypeNameHandling.Objects;

                var protocolAsJson = JsonConvert.SerializeObject(this, serializerSettîng);

                writer.Write(protocolAsJson);
            }
        }

        private static KnownTypesBinder CreateBinder()
        {
            var binder = new KnownTypesBinder()
            {
                KnownTypes = knownCommands.Keys.ToList()
            };

            binder.KnownTypes.Add(typeof(InvoiceProcess));
            binder.KnownTypes.Add(typeof(InvoiceItem));
            return binder;
        }

        public static InvoiceProcess LoadFrom(FileInfo targetFile)
        {
            var serializerSettîng = new JsonSerializerSettings();

            serializerSettîng.TypeNameHandling = TypeNameHandling.Objects;
            
            serializerSettîng.SerializationBinder = CreateBinder();

            using (var reader = new StreamReader(targetFile.FullName))
            {
                return JsonConvert.DeserializeObject<InvoiceProcess>(reader.ReadToEnd(), serializerSettîng);
            }
        }
        
    }
}
