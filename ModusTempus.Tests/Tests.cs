using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ModusTempus.Domain.Entities;
using ModusTempus.Domain.Services;
using ModusTempus.Domain.ValueObjects;

namespace ModusTempus.Tests
{
	[TestClass]
	public class Tests
	{
		[TestMethod]
		[ExpectedException(typeof(ArgumentException))]
		public void LongUsername()
		{
			var username = "useruseurhajnfjaifnpafapfiadhnpifpaidfaf";
			var email = "user@gmail.com";
			var password = "password";
			var user = new User(username, email, password);
		}

		[TestMethod]
		public void PasswordGeneration()
		{
			var username = "user";
			var email = "user@gmail.com";
			var password = "password";

			var user = new User(username, email, password);
			var hash = new HashingService().GeneratePasswordHash(password + user.Salt);
			Assert.AreEqual(user.Password, hash);
		}

		[TestMethod]
		public void Authorization1()
		{
			var user = new User("user", "user@gmail.com", "password");
			Assert.AreEqual(true, user.Authorize("password"));
		}

		[TestMethod]
		public void Authorization2()
		{
			var user = new User("user", "user@gmail.com", "password");
			Assert.AreEqual(false, user.Authorize("pasSword"));
		}

		[TestMethod]
		public void Authorization1UTF8()
		{
			var user = new User("user", "user@gmail.com", "ćevap");
			Assert.AreEqual(true, user.Authorize("ćevap"));
		}

		[TestMethod]
		public void Authorization2UTF8()
		{
			var user = new User("user", "user@gmail.com", "ćevap");
			Assert.AreEqual(false, user.Authorize("čevap"));
		}

		[TestMethod]
		[ExpectedException(typeof(InvalidOperationException))]
		public void UserCreateGroup()
		{
			var user = new User("user", "user@gmail.com", "password");
			var group = user.CreateGroup("group");
		}

		[TestMethod]
		public void AdminCreateGroup()
		{
			var user = new User("user", "user@gmail.com", "password") { Administrator = true };
			var group = user.CreateGroup("group");
			Assert.AreEqual(group.Permissions.First().User, user);
			Assert.AreEqual(group.Permissions.First().Type, PermissionType.Moderate);
		}

		[TestMethod]
		public void CreateActivity()
		{
			var user = new User("user", "user@gmail.com", "password");
			var group = new Group("group");
			var activity = group.CreateActivity("activity", null, new TimeSpan());
			Assert.AreEqual(activity.Group, group);
		}

		[TestMethod]
		public void Subscribe()
		{
			var user = new User("user", "user@gmail.com", "password") { Administrator = true };
			var group = new Group("group");
			user.Subscribe(group);
			Assert.AreEqual(group.Subscriptions.First().User, user);
		}

		[TestMethod]
		[ExpectedException(typeof(InvalidOperationException))]
		public void DoubleSubscribe()
		{
			var user = new User("user", "user@gmail.com", "password") { Administrator = true };
			var group = new Group("group");
			user.Subscribe(group);
			user.Subscribe(group);
		}

		[TestMethod]
		public void Unsubscribe()
		{
			var user = new User("user", "user@gmail.com", "password") { Administrator = true };
			var group = new Group("group");
			user.Subscribe(group);
			user.Unsubscribe(group);
		}

		[TestMethod]
		[ExpectedException(typeof(InvalidOperationException))]
		public void InvalidUnsubscribe()
		{
			var user = new User("user", "user@gmail.com", "password") { Administrator = true };
			var group = new Group("group");
			user.Unsubscribe(group);
		}

		[TestMethod]
		public void CreateChildActivity()
		{
			var group = new Group("group");
			var parent = group.CreateActivity("parent", null, new TimeSpan());
			var child = parent.CreateChild("child", DateTime.Now, new TimeSpan());
			Assert.AreEqual(parent, child.Parent);
		}

		[TestMethod]
		public void CreateDoubleParents()
		{
			var group = new Group("group");
			var child = group.CreateActivity("child", null, new TimeSpan());
			var parent = child.CreateParent("parent", DateTime.Now, new TimeSpan());
			var grandparent = parent.CreateParent("grandparent", DateTime.Now, new TimeSpan());
			Assert.AreEqual(child.Parent, parent);
			Assert.AreEqual(parent.Parent, grandparent);
		}

		[TestMethod]
		public void CreateSiblings()
		{
			var group = new Group("group");
			var parent = group.CreateActivity("parent", DateTime.Now, new TimeSpan());
			var child1 = parent.CreateChild("child1", DateTime.Now, new TimeSpan());
			var child2 = child1.CreateSibling("child2", DateTime.Now, new TimeSpan());
			Assert.AreEqual(child1.Parent, parent);
			Assert.AreEqual(child2.Parent, parent);
		}

		[TestMethod]
		[ExpectedException(typeof(ArgumentException))]
		public void InvalidCreateRecord()
		{
			var user = new User("user", "user@gmail.com", "password");
			var record = user.CreateRecord(TimeSpan.FromHours(2.5), null);
		}

		[TestMethod]
		public void CreatePermission()
		{
			var user = new User("user", "user@gmail.com", "password");
			var group = new Group("group");
			group.CreatePermission(user, PermissionType.None);
			Assert.AreEqual(PermissionType.None, group.Permissions.First().Type);
		}

		[TestMethod]
		public void CreatePermission2()
		{
			var user = new User("user", "user@gmail.com", "password");
			var group = new Group("group");
			group.CreatePermission(user, PermissionType.None);
			group.SetPermission(user, PermissionType.Read);
			Assert.AreEqual(PermissionType.Read, group.Permissions.First().Type);
		}

		[TestMethod]
		[ExpectedException(typeof(InvalidOperationException))]
		public void SetNonExistingPermission()
		{
			var user = new User("user", "user@gmail.com", "password");
			var group = new Group("group");
			group.SetPermission(user, PermissionType.Read);
		}
	}
}
