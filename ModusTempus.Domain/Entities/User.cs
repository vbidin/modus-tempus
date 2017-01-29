using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using ModusTempus.Domain.Services;
using ModusTempus.Domain.ValueObjects;

namespace ModusTempus.Domain.Entities
{
	public class User : Entity, IEquatable<User>
	{
		[Required]
		[Index(IsUnique = true)]
		[MaxLength(20)]
		public string Username { get; set; }

		[Required]
		[Index(IsUnique = true)]
		[MaxLength(40)]
		public string Email { get; set; }

		[Required]
		public string Password { get; set; }

		[Required]
		public string Salt { get; set; }

		[Required]
		public bool Administrator { get; set; }

		public virtual ICollection<Subscription> Subscriptions { get; set; }

		public virtual ICollection<Permission> Permissions { get; set; }

		private User() {}

		public User(string username, string email, string password)
		{
			if (username.Length > 20)
				throw new ArgumentException("Cannot create user, username is too long (" + username.Length +")");
			if (email.Length > 40)
				throw new ArgumentException("Cannot create user, email is too long (" + email.Length + ")");

			Username = username;
			Email = email;

			var hasher = new HashingService();
			Salt = hasher.GenerateSalt();
			Password = hasher.GeneratePasswordHash(password + Salt);

			Administrator = false;

			Subscriptions = new List<Subscription>();
			Permissions = new List<Permission>();
		}

		public bool Equals(User other)
		{
			var x = this as Entity;
			var y = other as Entity;
			return x.Equals(y);
		}

		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("User: " + Id + ", ");
			sb.Append("Username: " + Username + ", ");
			sb.Append("Email: " + Email + ", ");
			sb.Append("Admin: " + Administrator);
			return sb.ToString();
		}

		public bool Authorize(string password)
		{
			var hasher = new HashingService();
			var hash = hasher.GeneratePasswordHash(password + Salt);

			return hash == Password;
		}

		public Group CreateGroup(string name)
		{
			if (Administrator == false)
				throw new InvalidOperationException("Cannot create group '" + name + "': '" + this + "' is not an administrator.");

			var group = new Group(name);
			Subscribe(group);
			var permission = group.CreatePermission(this, PermissionType.Moderate);
			Permissions.Add(permission);
			
			return group;
		}

		public Record CreateRecord(TimeSpan duration, Activity activity)
		{
			if (activity == null)
				throw new ArgumentException("Cannot create record: activity is null.");

			var group = activity.Group;
			return new Record(duration, activity, this);
		}

		public Subscription Subscribe(Group group)
		{
			if (Subscriptions.Select(s => s.Group).Contains(group))
				throw new InvalidOperationException("Cannot subscribe to group '" + group.Name + "': '" + this + "' is already subscribed to it.");
			var sub = new Subscription(this, group);
			Subscriptions.Add(sub);
			group.Subscriptions.Add(sub);
			return sub;
		}

		public void Unsubscribe(Group group)
		{
			if (!Subscriptions.Select(s => s.Group).Contains(group))
				throw new InvalidOperationException("Cannot unsubscribe from group '" + group.Name + "': '" + this + "' is not subscribed to it.");
			var sub = Subscriptions.FirstOrDefault(s => s.Group.Equals(group));
			Subscriptions.Remove(sub);
			group.Subscriptions.Remove(sub);
		}
	}
}
