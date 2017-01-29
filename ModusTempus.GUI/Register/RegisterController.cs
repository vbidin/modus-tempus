namespace ModusTempus.GUI.Register
{
	public class RegisterController
	{
		private readonly RegisterModel _model;

		public RegisterController(RegisterModel model)
		{
			_model = model;
		}

		public void Register()
		{
			_model.Register();
		}
	}
}
