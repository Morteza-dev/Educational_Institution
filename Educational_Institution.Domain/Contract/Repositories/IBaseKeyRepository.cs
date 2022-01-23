using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Educational_Institution.Domain.Contract.Repositories
{
    public interface IBaseKeyRepository<TEntity,TKey>
    {
        TEntity Get(TKey key);
        TEntity Find(TKey key);
        void Delete(TKey key);

    }
}
