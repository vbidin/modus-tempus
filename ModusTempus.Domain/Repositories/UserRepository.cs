using System;
using System.Data.Entity;
using System.Linq;
using ModusTempus.Domain.Entities;

namespace ModusTempus.Domain.Repositories
{
	public class UserRepository : BaseRepository<User>
	{
		public User GetByUsername(string username)
		{
			using (var db = new Context())
			{
				return db.Users
					.Include(u => u.Subscriptions)
					.Include(u => u.Permissions)
					.FirstOrDefault(u => u.Username == username);
			}
		}

		public object GetByEmail(string email)
		{
			using (var db = new Context())
			{
				return db.Users
					.Include(u => u.Subscriptions)
					.Include(u => u.Permissions)
					.FirstOrDefault(u => u.Email == email);
			}
		}
	}
}
