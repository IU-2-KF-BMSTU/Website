using System;
using Website.Domain.Entities;
using Website.Domain.Entities.Enums;

namespace Website.Domain.DataSources.Teachers.Filters
{
	/// <summary>
	/// Представляет настройки фильтрации данных сущности <see cref="Teacher"/>.
	/// </summary>
	public class TeacherFilterSettings
	{
		/// <summary>
		/// Идентификатор кафедры.
		/// </summary>
		public Guid? DepartmentId { get; set; }
		/// <summary>
		/// Тип преподавания.
		/// </summary>
		public TeachingType? TeachingType { get; set; }
		/// <summary>
		/// Является ли преподаватель заведующим кафедрой.
		/// </summary>
		public bool? IsDepartmentHead { get; set; }
	}
}