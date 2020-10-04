using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Website.Infrastructure.Entities.DepartmentTeacherRelations;

namespace Website.Infrastructure.Entities
{
	/// <summary>
	/// Представляет сущность кафедры.
	/// </summary>
	public class DepartmentEntity
	{
		/// <summary>
		/// Идентификатор.
		/// </summary>
		public Guid Id { get; set; }
		/// <summary>
		/// Название.
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// Описание.
		/// </summary>
		public string Description { get; set; }
		/// <summary>
		/// Отношения с преподавателями.
		/// </summary>
		public virtual ICollection<DepartmentTeacherRelationEntity> TeacherRelations { get; set; } = new Collection<DepartmentTeacherRelationEntity>();
	}
}