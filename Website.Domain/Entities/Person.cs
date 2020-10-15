using System;

namespace Website.Domain.Entities
{
	/// <summary>
	/// Представляет сущность личности.
	/// </summary>
	public class Person
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
		/// Идентификатор изображения.
		/// </summary>
		public Guid? PictureId { get; set; }
		/// <summary>
		/// Дополнительная информация.
		/// </summary>
		public string AdditionalInfo { get; set; }
	}
}