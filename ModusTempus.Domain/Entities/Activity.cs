using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using ModusTempus.Domain.ValueObjects;

namespace ModusTempus.Domain.Entities
{
	public class Activity : Entity, IEquatable<Activity>
	{
		[Required]
		[MaxLength(40)]
		public string Name { get; set; }

		public Nullable<DateTime> Start { get; set; }

		public TimeSpan Duration { get; set; }

		public long GroupId { get; set; }
		public Group Group { get; set; }

		public Nullable<long> ParentId { get; set; }
		public Activity Parent { get; set; }

		public ICollection<Activity> Children { get; set; }

		public ICollection<Record> Records { get; set; }

		private Activity() {}

		public Activity(string name, Nullable<DateTime> start, TimeSpan duration, Group group)
		{
			Name = name;
			Start = start;
			Duration = duration;
			Group = group;

			Children = new List<Activity>();
			Records = new List<Record>();
		}

		public Activity(string name, Nullable<DateTime> start, TimeSpan duration, long groupId)
		{
			Name = name;
			Start = start;
			Duration = duration;
			GroupId = groupId;
		}

		public bool Equals(Activity other)
		{
			var x = this as Entity;
			var y = other as Entity;
			return x.Equals(y);
		}

		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("Activity: " + Id + ", ");
			sb.Append("Name: " + Name);
			return sb.ToString();
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
	}
}
