namespace ModusTempus.GUI.Login
{
	public interface ILoginView
	{
		LoginController Controller { get; set; }

		string Username { get; set; }
		string Password { get; set; }

		string Info { get; set; }

		void EnableLogin();
		void DisableLogin();
	}
}
