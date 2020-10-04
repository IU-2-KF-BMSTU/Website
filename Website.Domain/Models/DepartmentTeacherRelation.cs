using System;
using Website.Domain.Models.Enums;

namespace Website.Domain.Models
{
	/// <summary>
	/// Представляет информацию о связи преподавателя с кафедрой.
	/// </summary>
	public class DepartmentTeacherRelation
	{
		/// <summary>
		/// Идентификатор.
		/// </summary>
		public Guid Id { get; set; }
		/// <summary>
		/// Тип преподавания.
		/// </summary>
		public TeachingType TeachingType { get; set; }
		/// <summary>
		/// Является ли заведующим кафедрой.
		/// </summary>
		public bool IsDepartmentHead { get; set; }
	}
}