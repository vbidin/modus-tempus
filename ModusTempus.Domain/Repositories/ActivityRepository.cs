using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using ModusTempus.Domain.Entities;

namespace ModusTempus.Domain.Repositories
{
	public class ActivityRepository : BaseRepository<Activity>
	{
		public ICollection<Activity> GetChildren(Activity parent)
		{
			using (var db = new Context())
			{
				return db.Activities.Where(a => a.ParentId == parent.Id).ToList();
			}
		}

		public Activity GetById(long id)
		{
			using (var db = new Context())
			{
				return db.Activities
					.Include(a => a.Group)
					.FirstOrDefault(a => a.Id == id);
			}
		}

		// Recursively deletes all children dependents,
		// starting from the children up to the root.
		public override void Delete(Activity activity)
		{
			var children = GetChildren(activity);

			foreach (var child in children)
				Delete(child);

			using (var db = new Context())
			{
				db.Activities.Attach(activity);
				db.Activities.Remove(activity);
				db.SaveChanges();
			}

		}
	}
}
