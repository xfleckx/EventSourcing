using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Attendance.Events
{
    public class AttendanceEnded
    {
        public Guid User;
        public string Comment;
        public DateTime TimeStamp;
    }
}
