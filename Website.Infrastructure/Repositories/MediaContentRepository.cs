using System;
using System.Threading.Tasks;
using Website.Domain.Abstractions.Repositories;
using Website.Domain.Models;
using Website.Infrastructure.Entities;

namespace Website.Infrastructure.Repositories
{
	/// <summary>
	/// Представляет репозиторий для работы с медиаконтентом. 
	/// </summary>
	internal class MediaContentRepository : IMediaContentRepository
	{
		private readonly WebsiteDbContext _websiteDbContext;

		public MediaContentRepository(WebsiteDbContext websiteDbContext)
		{
			_websiteDbContext = websiteDbContext ?? throw new ArgumentNullException(nameof(websiteDbContext));
		}

		///<inheritdoc/>
		public Task CreateMediaContent(MediaContent mediaContent)
		{
			_websiteDbContext.MediaContents.Add(Convert(mediaContent));
			return _websiteDbContext.SaveChangesAsync();
		}

		///<inheritdoc/>
		public async Task<MediaContent> GetMediaContent(Guid id)
		{
			return Convert(await _websiteDbContext.MediaContents.FindAsync(id));
		}

		private MediaContent Convert(MediaContentEntity mediaContentEntity)
		{
			return new MediaContent
			{
				Id = mediaContentEntity.Id,
				FileName = mediaContentEntity.FileName,
				ContentType = mediaContentEntity.ContentType,
				Content = mediaContentEntity.Content,
			};
		}
		private MediaContentEntity Convert(MediaContent mediaContent) => new MediaContentEntity
		{
			Id = mediaContent.Id,
			FileName = mediaContent.FileName,
			ContentType = mediaContent.ContentType,
			Content = mediaContent.Content,
		};
	}
}