using DomainModel.Repositories;
using System;

namespace EventSourcing.UserInterface
{
    public static class RepositoryManagement
    {
        public static IUserRepository UserRepository;
        public static IAttendanceRepository AttendanceRepository;

        public static T Get<T>() where T : class
        {
            if (typeof(T) == typeof(IUserRepository))
            {
                return UserRepository as T;
            }

            if (typeof(T) == typeof(IAttendanceRepository))
            {
                return AttendanceRepository as T;
            }

            throw new NotImplementedException();
        }

    }
}