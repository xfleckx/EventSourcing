using DomainModel.Attendance.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Attendance
{
    public interface IEventHandling
    {
        void Apply(ICollection<Attendance> attendances, AttendanceStarted startedEvent);
        
        void Apply(ICollection<Attendance> attendances, AttendanceEnded endedEvent);
    }
}
