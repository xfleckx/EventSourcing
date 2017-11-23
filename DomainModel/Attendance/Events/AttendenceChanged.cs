using System;

namespace DomainModel.Attendance.Events
{
    public class AttendanceChanged
    {
        public Guid User;
        public Guid OriginalAttendance;
        public string Comment;

        public DateTime NewEndTime { get; set; }
        public DateTime NewStartTime { get; set; }
    }
}
