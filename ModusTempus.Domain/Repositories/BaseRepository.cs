using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;

namespace ModusTempus.Domain.Repositories
{
	public abstract class BaseRepository<T> : IRepository<T> where T : class
	{
		public virtual ICollection<T> GetBy(Expression<Func<T, bool>> predicate)
		{
			using (var db = new Context())
			{
				var query = db.Set<T>().Where(predicate);
				return query.ToList();
			}
		}

		public virtual ICollection<T> GetAll()
		{
			using (var db = new Context())
			{
				var query = db.Set<T>();
				return query.ToList();
			}
		}

		public virtual void Add(T entity)
		{
			using (var db = new Context())
			{
				db.Set<T>().Add(entity);
				db.SaveChanges();
			}
		}

		public virtual void Delete(T entity)
		{
			using (var db = new Context())
			{
				db.Set<T>().Attach(entity);
				db.Set<T>().Remove(entity);
				db.SaveChanges();
			}
		}

		public virtual void Edit(T entity)
		{
			using (var db = new Context())
			{
				db.Set<T>().AddOrUpdate(entity);
				db.SaveChanges();
			}
		}
	}
}