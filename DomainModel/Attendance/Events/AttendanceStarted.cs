using System;

namespace DomainModel.Attendance.Events
{
    public class AttendanceStarted
    {
        public Guid User;
        public string Comment;
        public DateTime TimeStamp;
    }
}
