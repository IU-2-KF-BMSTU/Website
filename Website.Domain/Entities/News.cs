using System;
using System.Collections.Generic;

namespace Website.Domain.Entities
{
	/// <summary>
	/// Представляет сущность новости.
	/// </summary>
	public class News
	{
		/// <summary>
		/// Идентификатор.
		/// </summary>
		public Guid Id { get; set; }
		/// <summary>
		/// Дата публикации.
		/// </summary>
		public DateTime PublicationDate { get; set; }
		/// <summary>
		/// Заголовок.
		/// </summary>
		public string Title { get; set; }
		/// <summary>
		/// Описание.
		/// </summary>
		public string Description { get; set; }
		/// <summary>
		/// Содержимое.
		/// </summary>
		public string Content { get; set; }
		/// <summary>
		/// Идентификаторы изображений.
		/// </summary>
		public Guid[] ImagesIds { get; set; }
	}
}