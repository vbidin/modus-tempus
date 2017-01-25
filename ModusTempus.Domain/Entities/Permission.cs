using System;
using System.ComponentModel.DataAnnotations;
using ModusTempus.Domain.ValueObjects;

namespace ModusTempus.Domain.Entities
{
	public class Permission : Entity, IEquatable<Permission>
	{
		[Required]
		[Range(0, 3)]
		public PermissionType Type { get; set; }	

		[Required]
		public User User { get; set; }

		[Required]
		public Group Group { get; set; }

		private Permission() {}

		public Permission(User user, Group group, PermissionType type)
		{
			User = user;
			Group = group;
			Type = type;
		}

		public bool Equals(Permission other)
		{
			var x = this as Entity;
			var y = other as Entity;
			return x == y;
		}
	}
}
