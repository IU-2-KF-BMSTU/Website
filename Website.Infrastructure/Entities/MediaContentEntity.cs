using System;

namespace Website.Infrastructure.Entities
{
	/// <summary>
	/// Представляет сущность медиаконтента.
	/// </summary>
	public class MediaContentEntity
	{
		/// <summary>
		/// Идентификатор.
		/// </summary>
		public Guid Id { get; set; }
		/// <summary>
		/// Название файла.
		/// </summary>
		public string FileName { get; set; }
		/// <summary>
		/// Тип файла.
		/// </summary>
		public string ContentType { get; set; }
		/// <summary>
		/// Содержимое.
		/// </summary>
		public byte[] Content { get; set; }
	}
}