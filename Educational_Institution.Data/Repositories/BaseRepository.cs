using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Educational_Institution.Domain.Contract.Repositories;
using Educational_Institution.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Educational_Institution.Data.Repositories
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        protected EI_DbContext _db { get; set; }
        protected DbSet<TEntity> dbSet { get; set; }
        public BaseRepository(EI_DbContext db)
        {
            _db = db;
            dbSet= _db.Set<TEntity>();
        }
        public async Task Add(TEntity entity)
        {
            await dbSet.AddAsync(entity);
        }

        public async Task Delete(TEntity entity)
        {
            await Task.Run(() => dbSet.Remove(entity));
        }

        public async Task<IEnumerable<TEntity>> Get(Expression<Func<TEntity, bool>> expression)
        {
            return await Task.Run(() =>
                dbSet.Where(expression)
            );
        }

        public async Task<IEnumerable<TEntity>> GetAll()
        {
            return await Task.Run(() => dbSet);
        }

        public async Task Update(TEntity entity)
        {
            await Task.Run(() =>
            {
                dbSet.Attach(entity);
                _db.Entry(entity).State = EntityState.Modified;
            });
        }
    }
}
