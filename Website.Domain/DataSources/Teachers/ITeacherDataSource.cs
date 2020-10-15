using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Website.Domain.DataSources.Teachers.Filters;
using Website.Domain.Entities;

namespace Website.Domain.DataSources.Teachers
{
	/// <summary>
	/// Представляет источник данных сущности <see cref="Teacher"/>.
	/// </summary>
	public interface ITeacherDataSource
	{
		/// <summary>
		/// Cоздаёт преподавателя.
		/// </summary>
		/// <param name="teacher">Модель преподавателя.</param>
		public void Add(Teacher teacher);
		/// <summary>
		/// Обновляет преподавателя.
		/// </summary>
		/// <param name="teacher">Модель преподавателя.</param>
		public void Update(Teacher teacher);
		/// <summary>
		/// Ассинхронно возвращает преподавателя.
		/// </summary>
		/// <param name="id">Идентификатор преподавателя.</param>
		/// <returns>Преподаватель.</returns>
		public Task<Teacher> FindAsync(Guid id);
		/// <summary>
		/// Асинхронно возвращает преподавателей.
		/// </summary>
		/// <param name="filterSettings">Настройки фильтрации.</param>
		/// <returns>Преподаватели.</returns>
		public Task<IEnumerable<Teacher>> FindAsync(TeacherFilterSettings filterSettings);
		/// <summary>
		/// Удаляет преподавателя.
		/// </summary>
		/// <param name="id">Идентификатор преподавателя.</param>
		public void Remove(Guid id);
	}
}