using System;
using System.Diagnostics;
using ModusTempus.Domain.Entities;
using ModusTempus.Domain.Repositories;

namespace ModusTempus.GUI.Login
{
	public class LoginModel
	{
		private readonly ILoginView _view;

		public User CurrentUser { get; set; }

		public LoginModel(ILoginView view)
		{
			_view = view;

			CurrentUser = null;

			_view.EnableLogin();
		}

		public bool Login(string username, string password)
		{
			if (CurrentUser != null)
				throw new InvalidOperationException("Cannot login: already logged in as '" + CurrentUser.Username + "'.");

			User user = new UserRepository().GetByUsername(username);

			if (user == null)
			{
				_view.Info = "Username does not exist.";
				return false;
			}

			bool success = user.Authorize(password);

			if (!success)
			{
				_view.Info = "Invalid password.";
				return false;
			}

			CurrentUser = user;
			_view.Info = "Logged in as '" + username + "'.";
			_view.DisableLogin();
			return true;
		}

		public bool Logout()
		{
			if (CurrentUser == null)
				throw new InvalidOperationException("Cannot logout: not logged in.");

			CurrentUser = null;
			_view.Info = "Logged out.";
			_view.EnableLogin();
			return true;
		}
	}
}
