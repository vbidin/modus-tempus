using System;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ModusTempus.Domain.Entities;
using ModusTempus.Domain.Model;

namespace ModusTempus.Tests
{
	[TestClass]
	public class Test
	{
		[TestMethod]
		public void Tests()
		{
			using (var db = new Context())
			{
				var user = db.Users.FirstOrDefault(u => u.Username == "pero");
				Debug.WriteLine(user);
			}
		}
	}
}
