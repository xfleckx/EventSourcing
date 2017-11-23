using DomainModel.Users;
using System;

namespace DomainModel.Attendance
{
    // becomes an aggregate
    public class Attendance
    {
        public Guid Guid;
        public Guid UserId;
        public DateTime Start;
        public DateTime End;

        public TimeSpan GetDuration()
        {
            return  End - Start;
        }
    }
}
