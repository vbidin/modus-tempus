using System;
using System.Linq;
using System.Linq.Expressions;

namespace ModusTempus.Domain.Repositories
{
	public interface IRepository<T> where T : class
	{
		IQueryable<T> GetBy(Expression<Func<T, bool>> predicate);
		IQueryable<T> GetAll();

		void Add(T entity);

		void Edit(T entity);

		void Delete(T entity);
		
		void Save();
	}
}
