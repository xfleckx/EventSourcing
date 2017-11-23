using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Repositories
{
    public interface IRepository<T>
    {
        void Add(T newEntity);

        void Update(T entity);

        T GetById(Guid id);
        T GetById(Guid id, int version);

        IEnumerable<T> All { get; }

        void Delete(T entity);
        // not sure what the update headers part means
        //void Save(T aggregate, Guid commitId, Action<IDictionary<string, object>> updateHeaders);
    }
}
