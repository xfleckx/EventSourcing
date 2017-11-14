using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventSourcing.DomainEvents
{
    public abstract class ADomainEvent : IDomainEvent
    {
        private Guid guid;

        public Guid Guid
        {
            get
            {
                if (guid == null)
                    guid = Guid.NewGuid();

                return guid;
            }
        }

        public DateTime Created;
    }
}
