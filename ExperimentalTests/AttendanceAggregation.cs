using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DomainModel.Attendance;
using System.Collections.Generic;
using DomainModel.Attendance.Events;

namespace ExperimentalTests
{
    [TestClass]
    public class AttendanceAggregation
    {
        [TestMethod]
        public void CreateNewAttendance()
        {
            var handler = new EventHandling();

            var attendances = new List<Attendance>();

            var userGuid = Guid.NewGuid();

            var now = DateTime.Now;

            var startEvent = new AttendanceStarted()
            {
                TimeStamp = now,
                User = userGuid
            };

            handler.Apply(attendances, startEvent);

            var endEvent = new AttendanceEnded()
            {
                TimeStamp = now.AddHours(1),
                User = userGuid
            };

            handler.Apply(attendances, endEvent);

            Assert.IsNotNull(attendances.Single(a => a.GetDuration() == TimeSpan.FromHours(1)));
        }

        [TestMethod]
        public void AttendanceRecievedAChange()
        {
            var handler = new EventHandling();

            var attendances = new List<Attendance>();

            var userGuid = Guid.NewGuid();

            var now = DateTime.Now;

            var startEvent = new AttendanceStarted()
            {
                TimeStamp = now,
                User = userGuid
            };

            handler.Apply(attendances, startEvent);

            var endEvent = new AttendanceEnded()
            {
                TimeStamp = now.AddHours(3),
                User = userGuid
            };

            var attendance = attendances.First();

            handler.Apply(attendances, endEvent);

            var changedEvent = new AttendanceChanged()
            {
                User = userGuid,
                OriginalAttendance = attendance.Guid,
                Comment = "Manual change",
                NewStartTime = attendance.Start.AddHours(1),
                NewEndTime = attendance.End
            };

            handler.Apply(attendances, changedEvent);

            Assert.IsNotNull(attendances.Single(a => a.GetDuration() == TimeSpan.FromHours(2)));
        }
    }
}
