using System;
using Website.Domain.Models.Enums;

namespace Website.Infrastructure.Entities.DepartmentTeacherRelations
{
	/// <summary>
	/// Представляет информацию о связи преподавателя с кафедрой.
	/// </summary>
	public class DepartmentTeacherRelationEntity
	{
		/// <summary>
		/// Идентификатор.
		/// </summary>
		public Guid Id { get; set; }
		/// <summary>
		/// Кафедра.
		/// </summary>
		public DepartmentEntity Department { get; set; }
		/// <summary>
		/// Идентификатор кафедры.
		/// </summary>
		public Guid DepartmentId { get; set; }
		/// <summary>
		/// Преподаватель.
		/// </summary>
		public TeacherEntity Teacher { get; set; }
		/// <summary>
		/// Идентификатор преподавателя.
		/// </summary>
		public Guid TeacherId { get; set; }
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