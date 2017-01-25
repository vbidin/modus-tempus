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
		public Activity Activity { get; set; }

		[Required]
		public User Creator { get; set; }

		private Record() { }

		public Record(TimeSpan duration, Activity activity, User creator)
		{
			Timestamp = DateTime.Now;
			Duration = duration;
			Activity = activity;
			Creator = creator;
		}

		public bool Equals(Record other)
		{
			var x = this as Entity;
			var y = other as Entity;
			return x == y;
		}
	}
}
