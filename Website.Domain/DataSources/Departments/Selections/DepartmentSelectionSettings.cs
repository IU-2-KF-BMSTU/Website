using Website.Domain.Entities;

namespace Website.Domain.DataSources.Departments.Selections
{
	/// <summary>
	/// Представляет настройки для выполнения выборки по <see cref="Department"/>.
	/// </summary>
	public class DepartmentSelectionSettings
	{
		/// <summary>
		/// Флаг включения информации о преподавателях.
		/// </summary>
		public bool IncludeTeachers { get; set; }
	}
}