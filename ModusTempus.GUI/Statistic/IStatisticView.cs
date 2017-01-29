namespace ModusTempus.GUI.Statistic
{
	using Statistic = Domain.ValueObjects.Statistic;

	public interface IStatisticView
	{
		StatisticController Controller { get; set; }

		string StatisticName { get; set; }

		Statistic Statistic { get; set; }

		void DrawStatistic();
	}
}
