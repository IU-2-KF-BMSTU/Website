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
		/// Ассинхронно создаёт вопрос.
		/// </summary>
		/// <param name="question">Модель вопроса.</param>
		Task CreateQuestionAsync(Question question);
		/// <summary>
		/// Ассинхронно возвращает модель вопроса.
		/// </summary>
		/// <param name="id">Идентификатор вопроса.</param>
		/// <returns>Модель вопроса.</returns>
		Task<Question> GetQuestionAsync(Guid id);
		/// <summary>
		/// Ассинхронно возвращает вопросы.
		/// </summary>
		/// <param name="offset">Количество пропускаемых элементов.</param>
		/// <param name="count">Количество выгружаемых элементов.</param>
		/// <returns>Вопросы</returns>
		Task<CollectionResult<Question>> GetQuestionsAsync(int offset, int count);
	}
}