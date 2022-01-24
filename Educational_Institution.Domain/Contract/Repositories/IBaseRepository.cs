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
        Task Add(TEntity entity);
        Task Update(TEntity entity);
        Task Delete(TEntity entity);
        Task<IEnumerable<TEntity>> Get(Expression<Func<TEntity,bool>> expression);
        Task<IEnumerable<TEntity>> GetAll();

    }
}
