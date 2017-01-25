using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using ModusTempus.Domain.ValueObjects;

namespace ModusTempus.Domain.Entities
{
	public class Activity : Entity, IEquatable<Activity>
	{
		[Required]
		[MaxLength(40)]
		public string Name { get; set; }

		public DateTime Start { get; set; }

		public TimeSpan Duration { get; set; }

		[Required]
		public Group Group { get; set; }

		public Activity Parent { get; set; }

		public ICollection<Activity> Children { get; set; }

		public ICollection<Record> Records { get; set; }

		private Activity() {}

		public Activity(string name, DateTime start, TimeSpan duration, Group group)
		{
			Name = name;
			Start = start;
			Duration = duration;
			Group = group;
		}

		public bool Equals(Activity other)
		{
			var x = this as Entity;
			var y = other as Entity;
			return x == y;
		}

		public Activity CreateParent(string name, DateTime start, TimeSpan duration)
		{
			var parent = new Activity(name, start, duration, Group);
			parent.Parent = Parent;
			Parent = parent;
			return parent;
		}

		public Activity CreateSibling(string name, DateTime start, TimeSpan duration)
		{
			var sibling = new Activity(name, start, duration, Group);
			sibling.Parent = Parent;
			return sibling;
		}

		public Activity CreateChild(string name, DateTime start, TimeSpan duration)
		{
			var child = new Activity(name, start, duration, Group);
			child.Parent = this;
			return child;
		}

		public Statistic GenerateStatistic()
		{
			// Create a new statistic for this activity here.
			return null;
		}
	}
}
