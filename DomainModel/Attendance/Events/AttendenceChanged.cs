using System;

namespace DomainModel.Attendance.Events
{
    public class AttendenceChanged
    {
        public Guid User;
        public Guid Cause;
        public DateTime TimeStamp;
        public string Comment;
    }
}
