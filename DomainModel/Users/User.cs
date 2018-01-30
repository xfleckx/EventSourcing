using System;

namespace DomainModel.Users
{
    public class User : IUniqueEntity
    {
        private Guid guid;
        public Guid Guid { get => guid; set => guid = value; }

        private string name;
        public string Name { get => name; set => name = value; }

        private string nick;
        public string Nick
        {
            get { return nick; }
            set { nick = value; }
        }

    }
}
