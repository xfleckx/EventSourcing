using EventSourcing.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventSourcing.UserInterface
{
    public class AddUserController
    {
        private Guid _guid;

        public Guid GuidForNewUser
        {
            get
            {
                if (_guid == null)
                    _guid = Guid.NewGuid();

                return _guid;
            }
        }

        internal void CreateNewUser(string expectedName)
        {
            var command = new CreateUserCommand(expectedName, _guid);

            // reset the controller for the next call
            _guid = Guid.NewGuid();
        }
    }
}
