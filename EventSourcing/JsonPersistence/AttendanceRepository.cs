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
    class AttendanceRepository : AJsonRepository<Workday>, IAttendanceRepository
    {
        public AttendanceRepository(FileInfo jsonFile)
        {
            InitializeCacheWith(jsonFile);
        }

        public void Add(Workday newEntity)
        {
            cache.Add(newEntity);
        }

        public IEnumerable<Workday> GetByDate(DateTime date)
        {
            return cache.Where(wd => wd.Date == date);
        }

        public IEnumerable<Workday> GetByDateRange(DateTime dateStart, DateTime dateEnd)
        {
            return cache.Where(wd => 
            wd.Date >= dateStart.Date && 
            wd.Date <= dateEnd.Date);
        }

        public Workday GetById(Guid id)
        {
            return cache.Find(wd => wd.Guid == id);
        }

        public Workday GetById(Guid id, int version)
        {
            return cache.Find(wd => wd.Guid == id);
        }

        public void Delete(Workday entity)
        {
            cache.Remove(entity);
        }

        public void Update(Workday entity)
        {
            if (!cache.Any(e => e.Guid == entity.Guid))
            {
                throw new InvalidOperationException($"Entity with Guid {entity.Guid} not found in the Repository");
            }
            else
            {
                var index = cache.FindIndex(wd => wd.Guid == entity.Guid);

                cache[index] = entity;
            }
        }
    }
}
