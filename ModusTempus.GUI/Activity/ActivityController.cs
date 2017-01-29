using ModusTempus.GUI.Forms;
using ModusTempus.GUI.Statistic;

namespace ModusTempus.GUI.Activity
{
	public class ActivityController
	{
		private readonly ActivityModel _model;

		public ActivityController(ActivityModel model)
		{
			_model = model;
		}

		public void ActivitySelected(string sid)
		{
			long id = long.Parse(sid);
			_model.SelectActivity(id);
		}

		public void Record(int duration)
		{
			if (_model.SelectedActivity == null)
				return;
			if (duration > 0)
				_model.AddRecord(duration);
		}

		public void ViewStatistics()
		{
			if (_model.SelectedActivity == null)
				return;

			var form = new StatisticForm();
			var model = new StatisticModel(form, _model.CurrentUser.Username, _model.SelectedActivity.Id);
			form.Controller = new StatisticController(model);
			form.Show();
		}

		public void CreateActivity(string name)
		{
			_model.CreateChildActivity(name);
		}

		public void DeleteActivity()
		{
			_model.DeleteActivity();
		}
	}
}
