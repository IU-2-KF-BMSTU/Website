using Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using Website.Domain.DataSources;
using Website.Domain.Entities;
using Website.Infrastructure.Extensions;

namespace Website.Infrastructure.DataSources
{
	internal class QuestionDataSource : IQuestionDataSource
	{
		private readonly WebsiteDbContext _websiteDbContext;

		public QuestionDataSource(WebsiteDbContext websiteDbContext)
		{
			_websiteDbContext = websiteDbContext ?? throw new ArgumentNullException(nameof(websiteDbContext));
		}

		public Task CreateQuestionAsync(Question question)
		{
			return Task.FromResult(_websiteDbContext.Questions.Add(question));
		}
		public async Task<Question> GetQuestionAsync(Guid id)
		{
			return await _websiteDbContext.Questions.FindAsync(id);
		}
		public async Task<CollectionResult<Question>> GetQuestionsAsync(int offset, int count)
		{
			int totalCount = await _websiteDbContext.Questions.CountAsync();
			Question[] questions = await _websiteDbContext.Questions.OrderByDescending(x => x.Date)
																	.ApplyPagingOption(offset, count)
																	.ToArrayAsync();
			return new CollectionResult<Question>(totalCount, questions);
		}
	}
}