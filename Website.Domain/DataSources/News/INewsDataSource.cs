using Common;
using System;
using System.Threading.Tasks;
using Website.Domain.Entities;

namespace Website.Domain.DataSources.NewsDS
{
	/// <summary>
	/// Представляет источник данных сущности <see cref="News"/>.
	/// </summary>
	public interface INewsDataSource
	{
		/// <summary>
		/// Cоздаёт новость.
		/// </summary>
		/// <param name="news">Модель новости.</param>
		public void Add(News news);
		/// <summary>
		/// Обновляет новость.
		/// </summary>
		/// <param name="news">Модель новости.</param>
		public void Update(News news);
		/// <summary>
		/// Ассинхронно возвращает новость.
		/// </summary>
		/// <param name="id">Идентификатор новости.</param>
		/// <returns>Новость.</returns>
		public Task<News> FindAsync(Guid id);
		/// <summary>
		/// Асинхронно возвращает новости.
		/// </summary>
		/// <param name="offset">Количество пропускаемых элементов.</param>
		/// <param name="count">Количество выгружаемых элементов.</param>
		/// <returns>Новости.</returns>
		public Task<CollectionResult<News>> FindAsync(int offset, int count);
		/// <summary>
		/// Удаляет новость.
		/// </summary>
		/// <param name="id">Идентификатор новости.</param>
		public void Remove(Guid id);
	}
}