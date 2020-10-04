using System;

namespace Website.Domain.Models
{
	/// <summary>
	/// Представляет модель медиаконтента.
	/// </summary>
	public class MediaContent
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