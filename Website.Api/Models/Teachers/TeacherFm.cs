using System;
using Website.Domain.Models.Enums;

namespace Website.Api.Models.Teachers
{
	/// <summary>
	/// Представляет модель создания преподавателя.
	/// </summary>
	public class TeacherFm
	{
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
		/// Тип преподавания.
		/// </summary>
		public TeachingType TeachingType { get; set; }
	}
}