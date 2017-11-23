using DomainModel.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel.Users;
using System.IO;

namespace EventSourcing.JsonPersistence
{
    public class UserRepository : AJsonRepository<User>, IUserRepository
    {
        public UserRepository(FileInfo fileInfo)
        {
            this.InitializeCacheWith(fileInfo);
        }

        public IEnumerable<User> All => cache;

        public void Add(User newEntity)
        {
            if (cache.Any(e => e.Guid == newEntity.Guid))
            {
                throw new InvalidOperationException($"Entity with Guid {newEntity.Guid} exists already in the Repository");
            }
            else
            {
                cache.Add(newEntity);
            }
        }

        public void Delete(User entity)
        {
            if (!cache.Any(e => e.Guid == entity.Guid))
            {
                throw new InvalidOperationException($"Entity with Guid {entity.Guid} not found in the Repository");
            }
            else
            {
                cache.Remove(entity);
            }
        }

        public User GetById(Guid id)
        {
            return cache.Find(u => u.Guid == id);
        }

        public User GetById(Guid id, int version)
        {
            return cache.Find(u => u.Guid == id);
        }

        public bool NameAvailable(string text)
        {
            return !cache.Any(u => u.Name == text);
        }

        public bool NickAvailable(string text)
        {
            return !cache.Any(u => u.Nick == text);
        }
        
        public void Update(User entity)
        {
            if (!cache.Any(e => e.Guid == entity.Guid))
            {
                throw new InvalidOperationException($"Entity with Guid {entity.Guid} not found in the Repository");
            }
            else
            {
                var index = cache.FindIndex(u => u.Guid == entity.Guid);

                cache[index] = entity;
            }
        }
    }
}
