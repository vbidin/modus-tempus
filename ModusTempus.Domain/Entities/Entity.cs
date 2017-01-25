using System;
using System.ComponentModel.DataAnnotations;

namespace ModusTempus.Domain.Entities
{
	public abstract class Entity : IEquatable<Entity>
	{
		[Key]
		public long Id { get; private set; }

		public override int GetHashCode()
		{
			return Id.GetHashCode();
		}

		public override bool Equals(object obj)
		{
			return this == obj as Entity;
		}

		public bool Equals(Entity other)
		{
			return this == other;
		}

		public static bool operator ==(Entity x, Entity y)
		{
			if (ReferenceEquals(x, y))
				return true;

			if (x == null || y == null)
				return false;

			if (x.GetType() != y.GetType())
				return false;

			if (x.Id != y.Id)
				return false;

			return true;
		}

		public static bool operator !=(Entity x, Entity y)
		{
			return !(x == y);
		}
	}
}
