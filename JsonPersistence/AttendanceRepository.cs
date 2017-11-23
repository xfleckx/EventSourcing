using DomainModel.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel.Attendance;
using System.IO;
using Newtonsoft.Json;

namespace EventSourcing.JsonPersistence
{
    public class AttendanceRepository : AJsonRepository<Attendance>, IAttendanceRepository
    {
        public IEnumerable<Attendance> All => cache;

        public AttendanceRepository(FileInfo jsonFile)
        {
            InitializeCacheWith(jsonFile);
        }

        public void Add(Attendance newEntity)
        {
            cache.Add(newEntity);
        }

        public IEnumerable<Attendance> GetByDate(DateTime date)
        {
            return cache.Where(a => a.Start == date);
        }

        public IEnumerable<Attendance> GetByDateRange(DateTime dateStart, DateTime dateEnd)
        {
            return cache.Where(a => 
            a.Start >= dateStart.Date && 
            a.Start <= dateEnd.Date);
        }

        public Attendance GetById(Guid id)
        {
            return cache.Find(a => a.Guid == id);
        }

        public Attendance GetById(Guid id, int version)
        {
            return cache.Find(a => a.Guid == id);
        }

        public void Delete(Attendance entity)
        {
            cache.Remove(entity);
        }

        public void Update(Attendance entity)
        {
            if (!cache.Any(e => e.Guid == entity.Guid))
            {
                throw new InvalidOperationException($"Entity with Guid {entity.Guid} not found in the Repository");
            }
            else
            {
                var index = cache.FindIndex(a => a.Guid == entity.Guid);

                cache[index] = entity;
            }
        }

        public IEnumerable<Attendance> GetAllForUser(Guid userId)
        {
            return cache.Where(a => a.UserId == userId);
        }
        
    }
}
