using System;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace ModusTempus.Domain.Repositories
{
	public abstract class BaseRepository<T> : IRepository<T> where T : class
	{
		protected BaseRepository()
		{
			Context = new Context();
		}

		public IQueryable<T> GetBy(Expression<Func<T, bool>> predicate)
		{
			IQueryable<T> query = Context.Set<T>().Where(predicate);
			return query;
		}

		public Context Context { get; }

		public virtual IQueryable<T> GetAll()
		{
			IQueryable<T> query = Context.Set<T>();
			return query;
		}

		public virtual void Add(T entity)
		{
			Context.Set<T>().Add(entity);
		}

		public virtual void Delete(T entity)
		{
			Context.Set<T>().Remove(entity);
		}

		public virtual void Edit(T entity)
		{
			Context.Entry(entity).State = EntityState.Modified;
		}

		public virtual void Save()
		{
			Context.SaveChanges();
		}
	}
}