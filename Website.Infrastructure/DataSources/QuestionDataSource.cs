using Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;
using Website.Domain.DataSources;
using Website.Domain.Entities;

namespace Website.Infrastructure.DataSources
{
	internal class BaseDataSource<TEntity, TDbContext>
		where TEntity : class
		where TDbContext : DbContext 
	{
		public BaseDataSource(TDbContext dbContext, DbSet<TEntity> dbSet)
		{
			DbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
			DbSet = dbSet;
		}

		protected TDbContext DbContext { get; private set; }
		protected DbSet<TEntity> DbSet { get; private set; }

		public void Add(TEntity entity)
		{
			DbSet.Add(entity);
		}
		public void Remove(TEntity entity)
		{
			DbSet.Remove(entity);
		}

	}
	internal class QuestionDataSource : BaseDataSource<Question, WebsiteDbContext>, IQuestionDataSource
	{
		public QuestionDataSource(WebsiteDbContext dbContext) : base(dbContext, dbContext.Questions) { }

		public Task CreateQuestionAsync(Question question)
		{
			Add(question);
		}
		public Task<Question> GetQuestionAsync(Guid id) => throw new NotImplementedException();
		public Task<CollectionResult<Question>> GetQuestionsAsync(int offset, int count) => throw new NotImplementedException();
	}
}