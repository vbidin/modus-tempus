using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using ModusTempus.Domain.Entities;

namespace ModusTempus.Domain.Repositories
{
	public class RecordRepository : BaseRepository<Record>
	{
		public ICollection<Record> GetByActivity(Activity activity)
		{
			using (var db = new Context())
			{
				return db.Records.Where(r => r.ActivityId == activity.Id).ToList();
			}
		}

		public ICollection<Record> GetByUserActivity(User user, Activity activity)
		{
			using (var db = new Context())
			{
				return db.Records.Where(r => r.ActivityId == activity.Id && r.CreatorId == user.Id).ToList();
			}
		}

		public ICollection<Record> GetByActivityRecursive(Activity activity)
		{
			using (var db = new Context())
			{
				return GetRecords(activity);
			}
		}

		private ICollection<Record> GetRecords(Activity activity)
		{
			var records = new RecordRepository().GetByActivity(activity);

			var children = new ActivityRepository().GetChildren(activity);
			foreach (var child in children)
				records = new Collection<Record>(records.Concat(GetRecords(child)).ToList());

			return records;
		}

		public ICollection<Record> GetByUserActivityRecursive(User user, Activity activity)
		{
			return GetByActivityRecursive(activity).Where(r => r.CreatorId == user.Id).ToList();
		}
	}
}
