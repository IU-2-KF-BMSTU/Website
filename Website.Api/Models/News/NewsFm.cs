using System;

namespace Website.Api.Models.News
{
	/// <summary>
	/// Представляет модель новости.
	/// </summary>
	public class NewsFm
	{
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