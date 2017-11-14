﻿using EventStore.ClientAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventSourcing
{
    public interface IDependOnEventStore
    {
        IEventStoreConnection Connection { get; }

        void Initialize(IEventStoreConnection currentConnection);
    }
}
