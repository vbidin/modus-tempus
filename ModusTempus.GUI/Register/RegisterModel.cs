using ModusTempus.Domain.Entities;
using ModusTempus.Domain.Repositories;

namespace ModusTempus.GUI.Register
{
	public class RegisterModel
	{
		private readonly IRegisterView _view;

		public RegisterModel(IRegisterView view)
		{
			_view = view;
		}

		public void Register()
		{
			var username = _view.Username;
			var email = _view.Email;
			var password = _view.Password;
			var repeatPassword = _view.RepeatPassword;

			if (string.IsNullOrWhiteSpace(username))
			{
				_view.Info = "Invalid username.";
				return;
			}

			if (string.IsNullOrWhiteSpace(email))
			{
				_view.Info = "Invalid email.";
				return;
			}

			if (string.IsNullOrWhiteSpace(password))
			{
				_view.Info = "Invalid password.";
				return;
			}

			if (new UserRepository().GetByUsername(username) != null)
			{
				_view.Info = "Username already in use.";
				return;
			}

			if (new UserRepository().GetByEmail(email) != null)
			{
				_view.Info = "Email already in use.";
				return;
			}

			if (password != repeatPassword)
			{
				_view.Info = "Passwords do not match.";
				return;
			}

			var user = new User(username, email, password);
			new UserRepository().Add(user);

			_view.Info = "User successfully registered.";
			_view.Password = "";
			_view.RepeatPassword = "";
		}
	}
}
