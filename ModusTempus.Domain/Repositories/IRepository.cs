using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace ModusTempus.Domain.Repositories
{
	public interface IRepository<T> where T : class
	{
		ICollection<T> GetBy(Expression<Func<T, bool>> predicate);
		ICollection<T> GetAll();

		void Add(T entity);
		void Edit(T entity);
		void Delete(T entity);
	}
}
