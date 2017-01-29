using ModusTempus.Domain.Entities;

namespace ModusTempus.GUI.Activity
{
	using Activity = Domain.Entities.Activity;

	public interface IActivityView
	{
		ActivityController Controller { get; set; }

		string SelectedActivityName { get; set; }
		string Info { get; set; }

		void AddRoot(Activity activity);
		void ClearTree();

		void EnableRecording();
		void DisableRecording();
		void TemporaryDisableRecording();

		void EnableModeration();
		void DisableModeration();
	}
}
