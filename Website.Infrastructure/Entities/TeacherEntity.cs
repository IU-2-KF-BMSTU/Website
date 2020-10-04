using System;
using Website.Infrastructure.Entities.DepartmentTeacherRelations;

namespace Website.Infrastructure.Entities
{
	/// <summary>
	/// Представляет сущность преподавателя.
	/// </summary>
	public class TeacherEntity
	{
		/// <summary>
		/// Идентификатор.
		/// </summary>
		public Guid Id { get; set; }
		/// <summary>
		/// Фамилия.
		/// </summary>
		public string Surname { get; set; }
		/// <summary>
		/// Имя.
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// Отчество.
		/// </summary>
		public string Patronymic { get; set; }
		/// <summary>
		/// Научная степень.
		/// </summary>
		public string Degree { get; set; }
		/// <summary>
		/// Дополнительная информация.
		/// </summary>
		public string AdditionalInfo { get; set; }
		/// <summary>
		/// Идентификатор изображения.
		/// </summary>
		public Guid? PictureId { get; set; }
		/// <summary>
		/// Отношение с кафедрой.
		/// </summary>
		public virtual DepartmentTeacherRelationEntity DepartmentRelation { get; set; }
		/// <summary>
		/// Идентификатор отношения с кафедрой.
		/// </summary>
		public Guid? DepartmentRelationId { get; set; }
	}
}