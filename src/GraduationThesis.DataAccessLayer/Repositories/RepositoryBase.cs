using GraduationThesis.DataAccessLayer.Contexts;
using GraduationThesis.DataAccessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GraduationThesis.DataAccessLayer.Repositories
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class, new()
    {
        private bool disposed = false;

        public HospitalContext Context { get; set; }
        public DbSet<T> Table { get; set; }

        public RepositoryBase()
        {
            Context = new HospitalContext();
            Table = Context.Set<T>();
        }

        public T FirstWithExplicitLoad(Expression<Func<T, bool>> filter, string[] paths = null)
        {
            IQueryable<T> temp = Table;
            if (paths != null)
            {
                foreach (var item in paths)
                {
                    temp = temp.Include(item);
                }
            }
            return temp.FirstOrDefault(filter);
        }

        public bool AnyWithExplicitLoad(Expression<Func<T, bool>> filter = null, string[] paths = null)
        {
            IQueryable<T> temp = Table;
            if (paths != null)
            {
                foreach (var item in paths)
                {
                    temp = temp.Include(item);
                }
            }
            if (filter == null) return temp.Any();
            else return temp.Any(filter);
        }

        public int CountWithExplicitLoad(Expression<Func<T, bool>> filter = null, string[] paths = null)
        {
            IQueryable<T> temp = Table;
            if (paths != null)
            {
                foreach (var item in paths)
                {
                    temp = temp.Include(item);
                }
            }
            if (filter == null) return temp.Count();
            else return temp.Count(filter);
        }

        public IQueryable<TResult> SelectWithExplicitLoad<TResult>(Expression<Func<T, TResult>> selector, string[] paths = null)
        {
            IQueryable<T> temp = Table;
            if (paths != null)
            {
                foreach (var item in paths)
                {
                    temp = temp.Include(item);
                }
            }
            return temp.Select(selector);
        }

        public IQueryable<TResult> SelectWithExplicitLoad<TResult>(Expression<Func<T, bool>> filter, Expression<Func<T, TResult>> selector, string[] paths = null)
        {
            IQueryable<T> temp = Table;
            if (paths != null)
            {
                foreach (var item in paths)
                {
                    temp = temp.Include(item);
                }
            }
            return temp.Where(filter).Select(selector);
        }

        public IQueryable<T> WhereWithExplicitLoad(Expression<Func<T, bool>> filter, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string[] paths = null)
        {
            IQueryable<T> temp = Table;
            if (paths != null)
            {
                foreach (var item in paths)
                {
                    temp = temp.Include(item);
                }
            }
            if (orderBy == null) return temp.Where(filter);
            else return orderBy(temp).Where(filter);
        }

        public IEnumerable<T> GetAllWithExplicitLoad(string[] paths = null)
        {
            IQueryable<T> temp = Table;
            if (paths != null)
            {
                foreach (var item in paths)
                {
                    temp = temp.Include(item);
                }
            }
            return temp;
        }

        public void CUDOperation(T entity, EntityState state)
        {
            Context.Entry(entity).State = state;
        }

        public int SaveChanges()
        {
            return Context.SaveChanges();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    Context.Dispose();
                }
                disposed = true;
            }
        }
    }
}
