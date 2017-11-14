using DomainModel.Attendance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Repositories
{
    public interface IAttendanceRepository : IRepository<Workday>
    {
        IEnumerable<Workday> GetByDate(DateTime date);
        IEnumerable<Workday> GetByDateRange(DateTime dateStart, DateTime dateEnd);

    }
}
