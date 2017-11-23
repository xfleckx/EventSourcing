using DomainModel.Attendance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Repositories
{
    public interface IAttendanceRepository : IRepository<Attendance.Attendance>
    {
        IEnumerable<Attendance.Attendance> GetByDate(DateTime date);
        IEnumerable<Attendance.Attendance> GetByDateRange(DateTime dateStart, DateTime dateEnd);
        IEnumerable<Attendance.Attendance> GetAllForUser(Guid userId);
    }
}
