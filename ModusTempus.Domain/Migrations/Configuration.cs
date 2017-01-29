using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Reflection;
using System.Text;
using System.Xml;
using ModusTempus.Domain.Entities;
using ModusTempus.Domain.ValueObjects;

namespace ModusTempus.Domain.Migrations
{
	using System;
	using System.Data.Entity;
	using System.Data.Entity.Migrations;
	using System.Linq;

	internal sealed class Configuration : DbMigrationsConfiguration<Context>
	{
		public Configuration()
		{
			AutomaticMigrationsEnabled = true;
		}

		protected override void Seed(Context context)
		{
			// Generates an .edmx file in the 'Model' folder each time 'Update-Database' is called.
			using (var ctx = new Context())
			{
				var path = new Uri(Assembly.GetExecutingAssembly().CodeBase).AbsolutePath;
				using (var writer = new XmlTextWriter(path + @"\..\..\..\Model.edmx", Encoding.Default))
				{
					EdmxWriter.WriteEdmx(ctx, writer);
				}
			}

			// Add in an admin and some users.
			context.Users.AddOrUpdate(new User("admin", "admin@gmail.com", "admin") { Administrator = true });
			context.Users.AddOrUpdate(new User("user", "user@gmail.com", "user"));
			context.Users.AddOrUpdate(new User("ivan", "ivan@gmail.com", "ivan"));
			context.Users.AddOrUpdate(new User("pero", "pero@gmail.com", "pero"));
			context.Users.AddOrUpdate(new User("ilija", "ilija@gmail.com", "ilija"));
			context.SaveChanges();

			// Add in groups.
			context.Groups.AddOrUpdate(new Group("Transport") { DefaultPermission = PermissionType.Write });
			context.Groups.AddOrUpdate(new Group("FER") { DefaultPermission = PermissionType.Read });
			context.Groups.AddOrUpdate(new Group("Forbidden") { DefaultPermission = PermissionType.None });
			context.Groups.AddOrUpdate(new Group("Sample 1"));
			context.Groups.AddOrUpdate(new Group("Sample 2"));
			context.Groups.AddOrUpdate(new Group("Sample 3"));
			context.SaveChanges();

			// Add activities for the transport group.
			Group transport = context.Groups.Single(g => g.Name == "Transport");
			context.Activities.AddOrUpdate(new Activity("Train", null, TimeSpan.FromSeconds(0), transport.Id));
			Activity car = new Activity("Car", null, TimeSpan.FromSeconds(0), transport.Id);
			context.Activities.AddOrUpdate(car);
			context.Activities.AddOrUpdate(new Activity("Tram", null, TimeSpan.FromSeconds(0), transport.Id));
			Activity physical = new Activity("Physical", null, TimeSpan.FromSeconds(0), transport.Id);
			context.Activities.AddOrUpdate(physical);
			context.SaveChanges();

			Activity walking = new Activity("Walking", null, TimeSpan.FromMinutes(30), transport.Id) { ParentId = physical.Id };
			Activity bike = new Activity("Bike", null, TimeSpan.FromSeconds(0), transport.Id) { ParentId = physical.Id };
			context.Activities.AddOrUpdate(walking);
			context.Activities.AddOrUpdate(bike);
			context.SaveChanges();

			// Add records for the transport group.
			var ivan = context.Users.Single(u => u.Username == "ivan");
			var pero = context.Users.Single(u => u.Username == "pero");
			var ilija = context.Users.Single(u => u.Username == "ilija");

			ICollection<Record> records = new List<Record>();
			records.Add(new Record(TimeSpan.FromHours(2.5), walking.Id, ivan.Id));
			records.Add(new Record(TimeSpan.FromHours(2), walking.Id, pero.Id));
			records.Add(new Record(TimeSpan.FromHours(3.2), walking.Id, pero.Id));
			records.Add(new Record(TimeSpan.FromMinutes(20), walking.Id, pero.Id));
			records.Add(new Record(TimeSpan.FromHours(1.5), bike.Id, ivan.Id));
			records.Add(new Record(TimeSpan.FromHours(1.5), car.Id, ilija.Id));
			records.Add(new Record(TimeSpan.FromHours(4), car.Id, pero.Id));

			foreach (var record in records)
				context.Records.Add(record);
			context.SaveChanges();
		}
	}
}
