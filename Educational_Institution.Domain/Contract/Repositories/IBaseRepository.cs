using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Educational_Institution.Domain.Contract;

namespace Educational_Institution.Domain.Contract.Repositories
{
    public interface IBaseRepository<TEntity>
    {
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        IEnumerable<TEntity> Get(Expression<Func<TEntity,bool>> expression);
        IEnumerable<TEntity> GetAll();

    }
}
