using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventStore.ClientAPI;
using Newtonsoft.Json;

namespace EventSourcing
{
    public abstract class AReactor : IDependOnEventStore
    {
        protected IEventStoreConnection connection;

        public IEventStoreConnection Connection => connection;

        public void Initialize(IEventStoreConnection currentConnection)
        {
            connection = currentConnection;
        }

        protected T DecodeEvent<T>(byte[] bytes)
        {
            var json = Encoding.UTF8.GetString(bytes);

            return JsonConvert.DeserializeObject<T>(json);
        }
    }
}
