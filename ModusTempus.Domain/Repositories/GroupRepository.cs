using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.InteropServices;
using ModusTempus.Domain.Entities;

namespace ModusTempus.Domain.Repositories
{
	public class GroupRepository : BaseRepository<Group>
	{
		public Group GetByName(string name)
		{
			using (var db = new Context())
			{
				return db.Groups
					.Include(g => g.Activities)
					.FirstOrDefault(u => u.Name == name);
			}
		}

		public ICollection<Group> GetByUser(User user)
		{
			using (var db = new Context())
			{
				ICollection<long> subs = db.Subcriptions.Where(s => s.User.Id == user.Id).Select(x => x.Id).ToList();
				ICollection<Group> groups = db.Groups.Where(g => subs.Contains(g.Id)).ToList();
				return groups;
			}
		}

		public override void Delete(Group group)
		{
			using (var db = new Context())
			{
				db.Groups.Attach(group);
				db.Groups.Remove(group);
				db.SaveChanges();
			}
		}
	}
}
