using System;
using System.Collections.Generic;

namespace Website.Domain.Entities
{
	/// <summary>
	/// Представляет сущность кафедры.
	/// </summary>
	public class Department
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
		/// Заведующий кафедрой.
		/// </summary>
		public Teacher Head { get; set; }
		/// <summary>
		/// Преподаватели.
		/// </summary>
		public ICollection<Teacher> Teachers { get; set; }
	}
}