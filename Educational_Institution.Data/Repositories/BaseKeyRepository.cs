using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Educational_Institution.Domain.Contract.Repositories;
using Educational_Institution.Data.Context;

namespace Educational_Institution.Data.Repositories
{
    public class BaseKeyRepository<TEntity, TKey> : BaseRepository<TEntity> , IBaseKeyRepository<TEntity, TKey> where TEntity : class
    {
        public BaseKeyRepository(EI_DbContext db)
            : base(db)
        {

        }

        public async Task Delete(TKey key)
        {
            var temp = await Find(key);
            await Task.Run(() => dbSet.Remove(temp));
        }

        public async Task<TEntity> Find(TKey key)
        {
            return await dbSet.FindAsync(key);
        }
    }
}
