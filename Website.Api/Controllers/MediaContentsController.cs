using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Threading.Tasks;
using Website.Domain.Abstractions.Repositories;
using Website.Domain.Models;

namespace Website.Api.Controllers
{
	/// <summary>
	/// Представляет API для работы с медиаконтентом.
	/// </summary>
	[Route("[controller]")]
	[ApiController]
	public class MediaContentsController : ControllerBase
	{
		private readonly IMediaContentRepository _mediaContentRepository;

		public MediaContentsController(IMediaContentRepository mediaContentRepository)
		{
			_mediaContentRepository = mediaContentRepository ?? throw new ArgumentNullException(nameof(mediaContentRepository));
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
			await _mediaContentRepository.CreateMediaContent(mediaContent);
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
			MediaContent mediaContent = await _mediaContentRepository.GetMediaContent(id);
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
			MediaContent mediaContent = await _mediaContentRepository.GetMediaContent(id);
			return File(mediaContent.Content, mediaContent.ContentType, mediaContent.FileName);
		}
	}
}