using DomainModel.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Attendance
{
    // becomes an aggregate
    public class Attendance
    {
        public Guid Guid;
        public User UserId;
        public DateTime Start;
        public DateTime End;
    }
}
