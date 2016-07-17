using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fme.Core.Dal
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        IEnumerable<T> Get(System.Linq.Expressions.Expression<Func<T, bool>> filter, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy);
        IQueryable<T> Query();
        T Insert(T entity);
        T Delete(T entity);
        T Update(T entity);
        T Find(System.Linq.Expressions.Expression<Func<T, bool>> filter);
    }
}
