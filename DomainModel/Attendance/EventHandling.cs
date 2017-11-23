using System;
using System.Collections.Generic;
using DomainModel.Attendance.Events;
using System.Linq;

namespace DomainModel.Attendance
{
    public class EventHandling : IEventHandling
    {
        public void Apply(ICollection<Attendance> attendances, AttendanceStarted startedEvent)
        {
            Attendance attendance;

            if (attendances.Any())
            {
                attendance = attendances.Last();

                if (attendance.Start != null)
                    throw new InvalidOperationException($"An {typeof(AttendanceEnded).Name} event expected!");

            }

            attendance = new Attendance()
            {
                Guid = Guid.NewGuid(),
                UserId = startedEvent.User,
                Start = startedEvent.TimeStamp,
                End = startedEvent.TimeStamp
            };

            attendances.Add(attendance);
        }

        public void Apply(ICollection<Attendance> attendances, AttendanceEnded endedEvent)
        { 
            if (attendances.Any())
            {
                var att = attendances.Last();

                if (att.End != att.Start)
                    throw new InvalidOperationException($"An {typeof(AttendanceStarted).Name} event expected!");

                att.End = endedEvent.TimeStamp;
            }
        }

        public void Apply(List<Attendance> attendances, AttendanceChanged changedEvent)
        {
            var targetId = changedEvent.OriginalAttendance;

            if (!attendances.Any(a => a.Guid == targetId))
                throw new InvalidOperationException($"No attendance ( {targetId} ) available to recieve a change");

            var target = attendances.Single(a => a.Guid == targetId);

            target.Start = changedEvent.NewStartTime;
            target.End = changedEvent.NewEndTime;
        }
    }
}
