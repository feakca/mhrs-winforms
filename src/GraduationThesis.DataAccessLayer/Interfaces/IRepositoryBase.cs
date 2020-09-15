using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GraduationThesis.DataAccessLayer.Interfaces
{
    public interface IRepositoryBase<T> : IDisposable where T : class, new()
    {
        T FirstWithExplicitLoad(Expression<Func<T, bool>> filter, string[] paths = null);
        IQueryable<T> WhereWithExplicitLoad(Expression<Func<T, bool>> filter, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string[] paths = null);
        bool AnyWithExplicitLoad(Expression<Func<T, bool>> filter = null, string[] paths = null);
        int CountWithExplicitLoad(Expression<Func<T, bool>> filter = null, string[] paths = null);
        IQueryable<TResult> SelectWithExplicitLoad<TResult>(Expression<Func<T, TResult>> selector, string[] paths = null);
        IQueryable<TResult> SelectWithExplicitLoad<TResult>(Expression<Func<T, bool>> filter, Expression<Func<T, TResult>> selector, string[] paths = null);
        IEnumerable<T> GetAllWithExplicitLoad(string[] paths = null);
        void CUDOperation(T entity, EntityState state);
        int SaveChanges();
    }
}
