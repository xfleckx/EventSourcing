using System;

namespace DomainModel.Attendance.Events
{
    public class AttendanceEnded
    {
        public Guid User;
        public string Comment;
        public DateTime TimeStamp;
    }
}
