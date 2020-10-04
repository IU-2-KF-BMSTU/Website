using Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using Website.Domain.Abstractions.Repositories;
using Website.Domain.Models;
using Website.Infrastructure.Entities;

namespace Website.Infrastructure.Repositories
{
	/// <summary>
	/// Представляет репозиторий для работы с вопросами.
	/// </summary>
	internal class QuestionRepository : IQuestionRepository
	{
		private readonly WebsiteDbContext _websiteDbContext;

		public QuestionRepository(WebsiteDbContext websiteDbContext)
		{
			_websiteDbContext = websiteDbContext ?? throw new ArgumentNullException(nameof(websiteDbContext));
		}

		///<inheritdoc/>
		public Task CreateQuestionAsync(Question question)
		{
			_websiteDbContext.Questions.Add(Convert(question));
			return _websiteDbContext.SaveChangesAsync();
		}
		///<inheritdoc/>
		public async Task<Question> GetQuestionAsync(Guid questionId)
		{
			return Convert(await _websiteDbContext.Questions.FindAsync(questionId));
		}
		///<inheritdoc/>
		public async Task<CollectionResult<Question>> GetQuestionsAsync(int offset, int count)
		{
			int totalCount = await _websiteDbContext.Questions.CountAsync();
			QuestionEntity[] questions = await _websiteDbContext.Questions.OrderByDescending(x => x.Date).Skip(offset).Take(count).ToArrayAsync();
			return new CollectionResult<Question>(totalCount, questions.Select(x => Convert(x)));
		}

		private Question Convert(QuestionEntity questionEntity)
		{
			return new Question
			{
				Id = questionEntity.Id,
				Date = questionEntity.Date,
				QuestionerName = questionEntity.QuestionerName,
				Contact = questionEntity.Contact,
				Content = questionEntity.Content
			};
		}
		private QuestionEntity Convert(Question question) => new QuestionEntity
		{
			Id = question.Id,
			Date = question.Date,
			QuestionerName = question.QuestionerName,
			Contact = question.Contact,
			Content = question.Content
		};
	}
}