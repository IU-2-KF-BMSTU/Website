using System;
using System.Threading.Tasks;
using Website.Domain.Models;

namespace Website.Domain.Abstractions.Repositories
{
	/// <summary>
	/// Представляет репозиторий для работы с медиаконтентом.
	/// </summary>
	public interface IMediaContentRepository
	{
	    /// <summary>
		/// Создаёт медиаконтент.
		/// </summary>
		/// <param name="mediaContent">Модель медиаконтента.</param>
		public Task CreateMediaContent(MediaContent mediaContent);
		/// <summary>
		/// Возвращает медиаконтент.
		/// </summary>
		/// <param name="id">Идентификатор.</param>
		/// <returns>Медиаконтент</returns>
		public Task<MediaContent> GetMediaContent(Guid id);
	}
}