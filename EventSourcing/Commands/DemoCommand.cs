using EventSourcing.DomainEvents;
using System;

namespace EventSourcing.Commands
{
    public class DemoCommand : ACommand<DemoCommandApplied>
    {
        private string name;
        public string Name { get => name; set => name = value; }

        private string message;
        public string Message { get => message; set => message = value; }

        private int randomInt = 0;
        public int RandomInt { get => randomInt; set => randomInt = value; }

        public DemoCommand(string name, string message)
        {
            this.name = name;
            this.message = message;
        }

        public override void Execute()
        {
            randomInt = new Random().Next();

            var @event = new DemoCommandApplied()
            {
                Created = DateTime.Now,
                DomainName = name,
                DomainValue = randomInt,
                DomainMessage = "A random value"
            };

            Raise(@event);
        }
    }
}
