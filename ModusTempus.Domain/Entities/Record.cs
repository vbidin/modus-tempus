using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ModusTempus.Domain.Entities
{
	public class Record : Entity, IEquatable<Record>
	{
		[Required]
		public DateTime Timestamp { get; set; }

		[Required]
		public TimeSpan Duration { get; set; }

		[Required]
		public long ActivityId { get; set; }
		public Activity Activity { get; set; }

		[Required]
		public long CreatorId { get; set; }
		public User Creator { get; set; }

		private Record() { }

		public Record(TimeSpan duration, Activity activity, User creator)
		{
			Timestamp = DateTime.Now;
			Duration = duration;
			Activity = activity;
			Creator = creator;
		}

		public Record(TimeSpan duration, long activityId, long creatorId)
		{
			Timestamp = DateTime.Now;
			Duration = duration;
			ActivityId = activityId;
			CreatorId = creatorId;
		}

		public bool Equals(Record other)
		{
			var x = this as Entity;
			var y = other as Entity;
			return x.Equals(y);
		}
	}
}
