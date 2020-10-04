using System;

namespace Website.Domain.Models
{
	/// <summary>
	/// Представляет модель кафедры.
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
	}
}