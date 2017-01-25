using System;
using System.Security.Cryptography;
using System.Text;

namespace ModusTempus.Domain.Services
{
	public class HashingService
	{
		public string GeneratePasswordHash(string password)
		{
			var bytes = new UTF8Encoding().GetBytes(password);
			var hashBytes = SHA256.Create().ComputeHash(bytes);
			return Convert.ToBase64String(hashBytes);
		}

		public string GenerateSalt()
		{
			var rng = new RNGCryptoServiceProvider();
			var buffer = new byte[64];
			rng.GetBytes(buffer);
			return Convert.ToBase64String(buffer);
		}
	}
}
