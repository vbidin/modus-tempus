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
			return Equals(obj as Entity);
		}

		public bool Equals(Entity other)
		{
			if (ReferenceEquals(this, other))
				return true;

			if (other == null)
				return false;

			if (GetType() != other.GetType())
				return false;

			if (Id != other.Id)
				return false;

			return true;
		}
	}
}
