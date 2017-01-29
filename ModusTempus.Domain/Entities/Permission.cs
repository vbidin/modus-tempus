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

		public long UserId { get; set; }
		public User User { get; set; }

		public long GroupId { get; set; }
		public Group Group { get; set; }

		private Permission() {}

		public Permission(User user, Group group, PermissionType type)
		{
			User = user;
			Group = group;
			Type = type;
		}

		public Permission(long userId, long groupId, PermissionType type)
		{
			UserId = userId;
			GroupId = groupId;
			Type = type;
		}

		public bool Equals(Permission other)
		{
			var x = this as Entity;
			var y = other as Entity;
			return x.Equals(y);
		}
	}
}
