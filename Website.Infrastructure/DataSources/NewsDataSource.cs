using Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using Website.Domain.DataSources.NewsDS;
using Website.Domain.Entities;
using Website.Infrastructure.Extensions;

namespace Website.Infrastructure.DataSources
{
	///<inheritdoc/>
	internal class NewsDataSource : INewsDataSource
	{
		private readonly WebsiteDbContext _websiteDbContext;

		public NewsDataSource(WebsiteDbContext websiteDbContext)
		{
			_websiteDbContext = websiteDbContext ?? throw new ArgumentNullException(nameof(websiteDbContext));
		}

		///<inheritdoc/>
		public void Add(News news)
		{
			_websiteDbContext.News.Add(news);
		}
		///<inheritdoc/>
		public async Task<News> FindAsync(Guid id)
		{
			return await _websiteDbContext.News.FindAsync(id);
		}
		///<inheritdoc/>
		public async Task<CollectionResult<News>> FindAsync(int offset, int count)
		{
			int totalCount = await _websiteDbContext.News.CountAsync();
			News[] news = await _websiteDbContext.News.OrderByDescending(x => x.PublicationDate)
																	.ApplyPagingOption(offset, count)
																	.ToArrayAsync();
			return new CollectionResult<News>(totalCount, news);
		}
		///<inheritdoc/>
		public void Remove(Guid id)
		{
			_websiteDbContext.News.Remove(new News { Id = id });
		}
		///<inheritdoc/>
		public void Update(News news)
		{
			_websiteDbContext.News.Update(news);
		}
	}
}