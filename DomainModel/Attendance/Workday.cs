using DomainModel.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Attendance
{
    // becomes an aggregate
    public class Workday
    {
        public Guid Guid;
        public User UserId;
        public DateTime Date;

        #region Operator overloads

        public static bool operator <(DateTime dt, Workday workdaysDt)
        {
            return  dt.Date < workdaysDt.Date;
        }

        public static bool operator >(DateTime dt, Workday workdaysDt)
        {
            return dt.Date > workdaysDt.Date;
        }
        
        public static bool operator >=(DateTime dt, Workday workdaysDt)
        {
            return dt.Date >= workdaysDt.Date;
        }

        public static bool operator <=(DateTime dt, Workday workdaysDt)
        {
            return dt.Date <= workdaysDt.Date;
        }

        public static bool operator ==(DateTime dt, Workday workdaysDt)
        {
            return dt.Date == workdaysDt.Date;
        }

        public static bool operator !=(DateTime dt, Workday workdaysDt)
        {
            return dt.Date != workdaysDt.Date;
        }

        #endregion
    }
}
