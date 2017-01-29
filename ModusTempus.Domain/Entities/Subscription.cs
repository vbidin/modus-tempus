using System;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ModusTempus.Domain.Entities
{
	public class Subscription : Entity, IEquatable<Subscription>
	{
		public long UserId { get; set; }
		public User User { get; set; }

		public long GroupId { get; set; }
		public Group Group { get; set; }

		private Subscription() {}

		public Subscription(User user, Group group)
		{
			User = user;
			Group = group;
		}

		public Subscription(long userId, long groupId)
		{
			UserId = userId;
			GroupId = groupId;
		}

		public bool Equals(Subscription other)
		{
			var x = this as Entity;
			var y = other as Entity;
			return x.Equals(y);
		}

		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("Subscription: " + Id + ", ");
			sb.Append("User id: " + UserId + ", ");
			sb.Append("Group id: " + GroupId);
			return sb.ToString();
		}
	}
}
