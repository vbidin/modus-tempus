using System.Linq;
using ModusTempus.Domain.Entities;

namespace ModusTempus.Domain.Repositories
{
	public class PermissionRepository : BaseRepository<Permission>
	{
		public Permission Get(User user, Group group)
		{
			using (var db = new Context())
			{
				return db.Permissions.FirstOrDefault(p => p.UserId == user.Id && p.GroupId == group.Id);
			}
		}
	}
}
