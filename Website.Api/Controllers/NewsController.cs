using Common;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;
using Website.Api.Models.News;
using Website.Domain.DataSources.NewsDS;
using Website.Domain.Entities;
using Website.Infrastructure;

namespace Website.Api.Controllers
{
	/// <summary>
	/// Представляет API для работы с новостями.
	/// </summary>
	[Route("[controller]")]
	[ApiController]
	public class NewsController : ControllerBase
	{
		private readonly INewsDataSource _newsDataSource;
		private readonly WebsiteDbContext _websiteDbContext;

		public NewsController(INewsDataSource newsDataSource, WebsiteDbContext websiteDbContext)
		{
			_newsDataSource = newsDataSource ?? throw new ArgumentNullException(nameof(newsDataSource));
			_websiteDbContext = websiteDbContext ?? throw new ArgumentNullException(nameof(websiteDbContext));
		}

		/// <summary>
		/// Создаёт новость.
		/// </summary>
		/// <param name="newsFm">Модель создания новости.</param>
		/// <returns>Идентификатор новости.</returns>
		[HttpPost]
		public async Task<Guid> CreateNews(NewsFm newsFm)
		{
			if (string.IsNullOrEmpty(newsFm.Title))
				throw new ArgumentException($"{newsFm.Title} is null or empty.");
			if (string.IsNullOrEmpty(newsFm.Content))
				throw new ArgumentException($"{newsFm.Content} is null or empty.");

			News news = new News()
			{
				Id = Guid.NewGuid(),
				PublicationDate = DateTime.UtcNow,
				Title = newsFm.Title,
				Description = newsFm.Description,
				Content = newsFm.Content,
				ImagesIds = newsFm.ImagesIds,
			};
			_newsDataSource.Add(news);
			await _websiteDbContext.SaveChangesAsync();
			return news.Id;
		}
		/// <summary>
		/// Обновляет новость.
		/// </summary>
		/// <param name="newsId">Идентификатор новости.</param>
		/// <param name="newsFm">Модель создания новости.</param>
		[HttpPut("{newsId}")]
		public async Task UpdateNews(Guid newsId, NewsFm newsFm)
		{
			if (string.IsNullOrEmpty(newsFm.Title))
				throw new ArgumentException($"{newsFm.Title} is null or empty.");
			if (string.IsNullOrEmpty(newsFm.Content))
				throw new ArgumentException($"{newsFm.Content} is null or empty.");

			News news =  await GetNews(newsId);
			if (news == null)
				throw new Exception($"No {nameof(News)} with the specified id.");
			news.Title = newsFm.Title;
			news.Description = newsFm.Description;
			news.Content = newsFm.Content;
			news.ImagesIds = newsFm.ImagesIds;

			_newsDataSource.Update(news);
			await _websiteDbContext.SaveChangesAsync();
		}
		/// <summary>
		/// Возвращает новость.
		/// </summary>
		/// <param name="newsId">Идентификатор новости.</param>
		/// <returns>Модель новости.</returns>
		[HttpGet("{newsId}")]
		public Task<News> GetNews(Guid newsId) => _newsDataSource.FindAsync(newsId);
		/// <summary>
		/// Возвращает новости.
		/// </summary>
		/// <param name="page">Номер страницы.</param>
		/// <param name="count">Количество выгружаемых элементов.</param>
		/// <returns>Новости.</returns>
		[HttpGet]
		public async Task<CollectionResult<NewsShortModel>> GetNews(int page = 1, int count = 10)
		{
			if (page <= 0)
				throw new ArgumentOutOfRangeException(nameof(page));
			if (count < 0)
				throw new ArgumentOutOfRangeException(nameof(count));

			CollectionResult<News> result = await _newsDataSource.FindAsync((page - 1) * count, count);
			return new CollectionResult<NewsShortModel>(result.TotalCount, result.Data.Select(convert));

			NewsShortModel convert(News news) => new NewsShortModel
			{
				Id = news.Id,
				Title = news.Title,
				Description = news.Description,
				PublicationDate = news.PublicationDate,
				ImageId = news.ImagesIds?.FirstOrDefault()
			};
		}
		/// <summary>
		/// Удаляет новость
		/// </summary>
		/// <param name="newsId">Идентификатор новости.</param>
		[HttpDelete("{newsId}")]
		public Task RemoveNews(Guid newsId)
		{
			_newsDataSource.Remove(newsId);
			return _websiteDbContext.SaveChangesAsync();
		}
	}
}