using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using ModusTempus.Domain.Entities;

namespace ModusTempus.Domain
{
	public class Context : DbContext
	{
		public Context() {}

		public DbSet<User> Users { get; set; }
		public DbSet<Permission> Permissions { get; set; }
		public DbSet<Subscription> Subcriptions { get; set; }

		public DbSet<Group> Groups { get; set; }
		public DbSet<Activity> Activities { get; set; }
		public DbSet<Record> Records { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
		}
	}
}
