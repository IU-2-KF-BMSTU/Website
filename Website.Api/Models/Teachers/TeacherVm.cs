using System;

namespace Website.Api.Models.Teachers
{
	/// <summary>
	/// Представляет модель преподавателя.
	/// </summary>
	public class TeacherVm
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
	}
}