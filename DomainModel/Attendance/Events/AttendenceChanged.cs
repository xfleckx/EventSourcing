using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
