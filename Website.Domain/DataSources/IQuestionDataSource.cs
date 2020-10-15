using Common;
using System;
using System.Threading.Tasks;
using Website.Domain.Entities;

namespace Website.Domain.DataSources
{
	/// <summary>
	/// Представляет источник данных сущности <see cref="Question"/>.
	/// </summary>
	public interface IQuestionDataSource
	{
		/// <summary>
		/// Cоздаёт вопрос.
		/// </summary>
		/// <param name="question">Модель вопроса.</param>
		void Add(Question question);
		/// <summary>
		/// Ассинхронно возвращает модель вопроса.
		/// </summary>
		/// <param name="id">Идентификатор вопроса.</param>
		/// <returns>Модель вопроса.</returns>
		Task<Question> FindAsync(Guid id);
		/// <summary>
		/// Ассинхронно возвращает вопросы.
		/// </summary>
		/// <param name="offset">Количество пропускаемых элементов.</param>
		/// <param name="count">Количество выгружаемых элементов.</param>
		/// <returns>Вопросы</returns>
		Task<CollectionResult<Question>> FindAsync(int offset, int count);
	}
}