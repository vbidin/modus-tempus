using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using ModusTempus.Domain.Entities;

namespace ModusTempus.Domain.Repositories
{
	public class SubscriptionRepository : BaseRepository<Subscription>
	{
		public ICollection<Subscription> GetByUser(User user)
		{
			using (var db = new Context())
			{
				return db.Subcriptions.Include(g => g.Group).Where(s => s.UserId == user.Id).ToList();
			}
		}
	}
}
