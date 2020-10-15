using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Threading.Tasks;
using Website.Domain.DataSources;
using Website.Domain.Entities;
using Website.Infrastructure;

namespace Website.Api.Controllers
{
	/// <summary>
	/// Представляет API для работы с медиаконтентом.
	/// </summary>
	[Route("[controller]")]
	[ApiController]
	public class MediaContentsController : ControllerBase
	{
		private readonly IMediaContentDataSource _mediaContentDataSource;
		private readonly WebsiteDbContext _websiteDbContext;

		public MediaContentsController(IMediaContentDataSource mediaContentDataSource, WebsiteDbContext websiteDbContext)
		{
			_mediaContentDataSource = mediaContentDataSource ?? throw new ArgumentNullException(nameof(mediaContentDataSource));
			_websiteDbContext = websiteDbContext ?? throw new ArgumentNullException(nameof(websiteDbContext));
		}

		/// <summary>
		/// Добавляет медиаконтент.
		/// </summary>
		/// <param name="formFile">Медиаконтент.</param>
		/// <returns>Идентификатор.</returns>
		[HttpPost]
		public async Task<Guid> AddMediaContent(IFormFile formFile)
		{
			byte[] buffer = new byte[formFile.Length];
			using (Stream stream = formFile.OpenReadStream())
			{
				int receivedCount = 0;
				do
				{
					receivedCount += await stream.ReadAsync(buffer, receivedCount, buffer.Length - receivedCount);
				}
				while (receivedCount != buffer.Length);
			}

			MediaContent mediaContent = new MediaContent
			{
				Id = Guid.NewGuid(),
				FileName = formFile.FileName,
				ContentType = formFile.ContentType,
				Content = buffer
			};
			_mediaContentDataSource.Add(mediaContent);
			await _websiteDbContext.SaveChangesAsync();
			return mediaContent.Id;
		}
		/// <summary>
		/// Возвращает контент медиаконтента.
		/// </summary>
		/// <param name="id">Идентификатор.</param>
		/// <returns>Контент медиаконтента.</returns>
		[HttpGet("Content")]
		public async Task<FileContentResult> GetContent(Guid id)
		{
			MediaContent mediaContent = await _mediaContentDataSource.FindAsync(id);
			return new FileContentResult(mediaContent.Content, mediaContent.ContentType);
		}
		/// <summary>
		/// Возвращает файл.
		/// </summary>
		/// <param name="id">Идентификатор.</param>
		/// <returns>Файл.</returns>
		[HttpGet("File")]
		public async Task<FileContentResult> GetFile(Guid id)
		{
			MediaContent mediaContent = await _mediaContentDataSource.FindAsync(id);
			return File(mediaContent.Content, mediaContent.ContentType, mediaContent.FileName);
		}
	}
}