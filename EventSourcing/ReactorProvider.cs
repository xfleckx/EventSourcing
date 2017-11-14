using EventStore.ClientAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventSourcing
{
    public class ReactorProvider
    {
        private static IEventStoreConnection currentConnection;

        public static void Initialize(IEventStoreConnection connection)
        {
            currentConnection = connection;
        }

        public static C GetReactor<C>() where C : AReactor, new()
        {
            var instance = new C();
            instance.Initialize(currentConnection);

            return instance;
        }
    }
}
