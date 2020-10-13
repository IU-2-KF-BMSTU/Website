using System;
using System.Threading.Tasks;
using Website.Domain.Entities;

namespace Website.Domain.DataSources
{
	/// <summary>
	/// Представляет источник данных сущности <see cref="Teacher"/>.
	/// </summary>
	public interface ITeacherDataSource
	{
		/// <summary>
		/// Ассинхронно создаёт преподавателя.
		/// </summary>
		/// <param name="teacher">Модель преподавателя.</param>
		public Task CreateTeacherAsync(Teacher teacher);
		/// <summary>
		/// Ассинхронно обновляет преподавателя.
		/// </summary>
		/// <param name="teacher">Модель преподавателя.</param>
		public Task UpdateTeacherAsync(Teacher teacher);
		/// <summary>
		/// Ассинхронно возвращает преподавателя.
		/// </summary>
		/// <param name="id">Идентификатор преподавателя.</param>
		/// <returns>Преподаватель.</returns>
		public Task<Teacher> GetTeacherAsync(Guid id);
		/// <summary>
		/// Ассинхронно удаляет преподавателя.
		/// </summary>
		/// <param name="id">Идентификатор преподавателя.</param>
		public Task DeleteTeacherAsync(Guid id);
	}
}