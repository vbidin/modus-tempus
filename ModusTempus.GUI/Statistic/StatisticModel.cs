using System;
using System.Linq;
using ModusTempus.Domain.Repositories;
using ModusTempus.Domain.ValueObjects;

namespace ModusTempus.GUI.Statistic
{
	using Statistic = Domain.ValueObjects.Statistic;

	public class StatisticModel
	{
		private readonly IStatisticView _view;

		public Statistic Statistic { get; set; }

		public StatisticModel(IStatisticView view, string username, long activityId)
		{
			_view = view;

			var user = new UserRepository().GetByUsername(username);
			var activity = new ActivityRepository().GetById(activityId);

			var query = new RecordRepository().GetByUserActivityRecursive(user, activity).Select(r => r.Duration);
			var personal = TimeSpan.FromSeconds(0);
			if (query.Count() != 0)
				personal = query.Aggregate((x, y) => x + y);

			var count = new RecordRepository().GetByActivityRecursive(activity).Select(r => r.CreatorId).Distinct().Count();
			var average = TimeSpan.FromSeconds(0);
			if (count != 0)
			{
				average = new RecordRepository().GetByActivityRecursive(activity).Select(r => r.Duration).Aggregate((x, y) => x + y);
				average = TimeSpan.FromSeconds(average.TotalSeconds/count);
			}
			var expected = activity.Duration; 

			Statistic = new Statistic(personal, average, expected);
			Statistic.Unit = TimeUnit.Hours;

			_view.StatisticName = activity.Name;
			_view.Statistic = Statistic;
			_view.DrawStatistic();
		}
	}
}
