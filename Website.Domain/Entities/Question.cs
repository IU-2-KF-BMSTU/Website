using System;

namespace Website.Domain.Entities
{
	/// <summary>
	/// Представляет сущность вопроса.
	/// </summary>
	public class Question
	{
		/// <summary>
		/// Идентификатор.
		/// </summary>
		public Guid Id { get; set; }
		/// <summary>
		/// Дата.
		/// </summary>
		public DateTime Date { get; set; }
		/// <summary>
		/// Имя спрашивающего.
		/// </summary>
		public string QuestionerName { get; set; }
		/// <summary>
		/// Контактные данные.
		/// </summary>
		public string Contact { get; set; }
		/// <summary>
		/// Контент вопроса.
		/// </summary>
		public string Content { get; set; }
	}
}