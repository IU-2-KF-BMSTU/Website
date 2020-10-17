using System;

namespace Website.Api.Models.News
{
	/// <summary>
	/// Представляет короткую модель новости.
	/// </summary>
	public class NewsShortModel
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
		/// Идентификатор изображения.
		/// </summary>
		public Guid? ImageId { get; set; }
	}
}