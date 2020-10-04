using System;
using System.Threading.Tasks;
using Website.Domain.Models;

namespace Website.Domain.Abstractions.Repositories
{
	/// <summary>
	/// Представляет репозиторий для работы с преподавателями.
	/// </summary>
	public interface ITeacherRepository
	{
		/// <summary>
		/// Создаёт преподавателя.
		/// </summary>
		/// <param name="teacher">Модель преподавателя.</param>
		public Task CreateTeacher(Teacher teacher);
		/// <summary>
		/// Обновляет преподавателя.
		/// </summary>
		/// <param name="teacher">Модель преподавателя.</param>
		public Task UpdateTeacher(Teacher teacher);
		/// <summary>
		/// Возвращает преподавателя.
		/// </summary>
		/// <param name="id">Идентификатор преподавателя.</param>
		/// <returns>Преподаватель.</returns>
		public Task<Teacher> GetTeacher(Guid id);
		/// <summary>
		/// Удаляет преподавателя.
		/// </summary>
		/// <param name="id">Идентификатор преподавателя.</param>
		public Task DeleteTeacher(Guid id);
	}
}