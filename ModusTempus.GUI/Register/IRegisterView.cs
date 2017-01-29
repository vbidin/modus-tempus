namespace ModusTempus.GUI.Register
{
	public interface IRegisterView
	{
		RegisterController Controller { get; set; }

		string Username { get; set; }
		string Email { get; set; }
		string Password { get; set; }
		string RepeatPassword { get; set; }
		string Info { get; set; }
	}
}
