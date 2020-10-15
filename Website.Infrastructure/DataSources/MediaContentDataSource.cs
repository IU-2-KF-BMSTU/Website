using System;
using System.Threading.Tasks;
using Website.Domain.DataSources;
using Website.Domain.Entities;

namespace Website.Infrastructure.DataSources
{
	///<inheritdoc/>
	internal class MediaContentDataSource : IMediaContentDataSource
	{
		private readonly WebsiteDbContext _websiteDbContext;

		public MediaContentDataSource(WebsiteDbContext websiteDbContext)
		{
			_websiteDbContext = websiteDbContext ?? throw new ArgumentNullException(nameof(websiteDbContext));
		}

		///<inheritdoc/>
		public void Add(MediaContent mediaContent)
		{
			_websiteDbContext.MediaContents.Add(mediaContent);
		}
		///<inheritdoc/>
		public async Task<MediaContent> FindAsync(Guid id)
		{
			return await _websiteDbContext.MediaContents.FindAsync(id);
		}
	}
}