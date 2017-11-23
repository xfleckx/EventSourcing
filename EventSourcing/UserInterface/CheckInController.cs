using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventSourcing.UserInterface
{
    public class CheckInController
    {
        public event Action<DateTime, string> CheckInCommited;

        public event Action<DateTime, string> CheckOutCommited;

        public void CommitIn(DateTime dateTime, string message)
        {
            CheckInCommited?.Invoke(dateTime, message);
        }

        public void CommitOut(DateTime dateTime, string message)
        {
            CheckOutCommited?.Invoke(dateTime, message);
        }


    }
}
