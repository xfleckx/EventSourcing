using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Users
{
    public class User : IUniqueEntity
    {
        private Guid guid;

        public Guid Guid => guid;
    }
}
