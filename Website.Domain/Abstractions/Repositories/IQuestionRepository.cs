using Common;
using System;
using System.Threading.Tasks;
using Website.Domain.Models;

namespace Website.Domain.Abstractions.Repositories
{
	/// <summary>
	/// Представляет репозиторий для работы с вопросами.
	/// </summary>
	public interface IQuestionRepository
	{
		/// <summary>
		/// Ассинхронно создаёт вопрос.
		/// </summary>
		/// <param name="question">Модель вопроса.</param>
		public Task CreateQuestionAsync(Question question);
		/// <summary>
		/// Ассинхронно возвращает модель вопроса.
		/// </summary>
		/// <param name="questionId">Идентификатор вопроса.</param>
		/// <returns>Модель вопроса.</returns>
		public Task<Question> GetQuestionAsync(Guid questionId);
		/// <summary>
		/// Ассинхронно возвращает вопросы.
		/// </summary>
		/// <param name="offset">Количество пропускаемых элементов.</param>
		/// <param name="count">Количество выгружаемых элементов.</param>
		/// <returns>Вопросы</returns>
		public Task<CollectionResult<Question>> GetQuestionsAsync(int offset, int count);
	}
}