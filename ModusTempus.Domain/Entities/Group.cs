using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using ModusTempus.Domain.ValueObjects;

namespace ModusTempus.Domain.Entities
{
	public class Group : Entity, IEquatable<Group>
	{
		[Required]
		[Index(IsUnique = true)]
		[MaxLength(40)]
		public string Name { get; set; }

		[Required]
		[Range(0, 3)]
		public PermissionType DefaultPermission { get; set; }

		public virtual ICollection<User> Subscribers { get; set; }

		public virtual ICollection<Permission> Permissions { get; set; }

		public virtual ICollection<Activity> Activities { get; set; }

		private Group() {}

		public Group(string name)
		{
			Name = name;
			DefaultPermission = PermissionType.None;
		}

		public bool Equals(Group other)
		{
			var x = this as Entity;
			var y = other as Entity;
			return x == y;
		}

		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("Group: " + Id + ", ");
			sb.Append("Name: " + Name + ", ");
			sb.Append("\n");
			return sb.ToString();
		}

		public Permission CreatePermission(User user, PermissionType type)
		{
			var permission = Permissions.FirstOrDefault(p => p.User == user && p.Group == this);

			if (permission != null)
				throw new InvalidOperationException("Cannot create permission for user '" + user + "': permission already exists.");
			
			permission = new Permission(user, this, type);
			Permissions.Add(permission);
			return permission;
		}

		public void SetPermission(User user, PermissionType type)
		{
			var permission = Permissions.FirstOrDefault(p => p.User == user && p.Group == this);

			if (permission == null)
				throw new InvalidOperationException("Cannot modify permission for user '" + user +"': permission does not exist.");

			permission.Type = type;
		}

		public Activity CreateActivity(string name, DateTime start, TimeSpan duration)
		{
			var root = new Activity(name, start, duration, this);
			return root;
		}
	}
}
