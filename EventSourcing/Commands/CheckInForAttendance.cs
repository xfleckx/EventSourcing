using DomainModel.Attendance.Events;
using DomainModel.Repositories;
using System;
using System.Linq;

namespace EventSourcing.Commands
{
    public class 
        CheckInForAttendance : ACommand<AttendanceStarted>
    {
        public string Comment { get; set; }

        public Guid UserId { get; set; }

        private IAttendanceRepository attendancesRepo;

        public CheckInForAttendance(IAttendanceRepository repository)
        {
            attendancesRepo = repository;
        }

        public override void Execute()
        {
            var startedEvent = new AttendanceStarted()
            {
                Comment = Comment,
                TimeStamp = DateTime.Now,
                User = UserId
            };

            Raise(startedEvent);
        }

        public override bool Validate(Action<string> ValidationFailed)
        {
            if(UserId == null)
            {
                ValidationFailed?.Invoke("No user specified");

                return false;
            }

            var allForUser = attendancesRepo.GetAllForUser(UserId);

            if (allForUser.Any(a => a.Start == a.End))
            {
                ValidationFailed?.Invoke("An open attendance exists already!");

                return false;
            }

            throw new InvalidProgramException("Validation incomplete");
        }
    }
}
