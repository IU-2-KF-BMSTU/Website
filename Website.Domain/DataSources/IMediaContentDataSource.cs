using System;
using System.Threading.Tasks;
using Website.Domain.Entities;

namespace Website.Domain.DataSources
{
	/// <summary>
	/// Представляет источник данных сущности <see cref="MediaContent"/>.
	/// </summary>
	public interface IMediaContentDataSource
	{
		/// <summary>
		/// Cоздаёт медиаконтент.
		/// </summary>
		/// <param name="mediaContent">Модель медиаконтента.</param>
		public void Add(MediaContent mediaContent);
		/// <summary>
		/// Ассинхронно возвращает медиаконтент.
		/// </summary>
		/// <param name="id">Идентификатор.</param>
		/// <returns>Медиаконтент.</returns>
		public Task<MediaContent> FindAsync(Guid id);
	}
}