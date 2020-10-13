using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Website.Domain.Entities;
using Website.Domain.Entities.Enums;

namespace Website.Domain.DataSources
{
	/// <summary>
	/// Представляет источник данных сущности <see cref="Department"/>.
	/// </summary>
	public interface IDepartmentDataSource
	{
		/// <summary>
		/// Ассинхронно создаёт кафедру.
		/// </summary>
		/// <param name="department">Модель кафедры.</param>
		public Task CreateDepartmentAsync(Department department);
		/// <summary>
		/// Ассинхронно обновляет кафедру.
		/// </summary>
		/// <param name="department">Модель кафедры.</param>
		public Task UpdateDepartmentAsync(Department department);
		/// <summary>
		/// Ассинхронно возвращает сущность кафедры.
		/// </summary>
		/// <param name="id">Идентификатор кафедры.</param>
		/// <returns>Сущность кафедры.</returns>
		public Task<Department> GetDepartmentAsync(Guid id);
		/// <summary>
		/// Ассинхронно добавляет преподавателя на кафедру.
		/// </summary>
		/// <param name="departmentId">Идентификатор кафедры.</param>
		/// <param name="teacher">Преподаватель.</param>
		public Task AddTeacherAsync(Guid departmentId, Teacher teacher);
		/// <summary>
		/// Ассинхронно возвращает список преподавателей.
		/// </summary>
		/// <param name="departmentId">Идентификатор кафедры.</param>
		/// <param name="teachingType">Фильтр по типу преподавания.</param>
		/// <returns>Список преподавателей.</returns>
		public Task<IEnumerable<Teacher>> GetTeachersAsync(Guid departmentId, TeachingType? teachingType);
		/// <summary>
		/// Ассинхронно возвращает заведующего кафедрой.
		/// </summary>
		/// <param name="departmentId">Идентификатор кафедры.</param>
		/// <returns>Заведующий кафедрой.</returns>
		public Task<Teacher> GetHeadAsync(Guid departmentId);
		/// <summary>
		/// Ассинхронно устанавливаем заведующего кафедрой.
		/// </summary>
		/// <param name="departmentId">Идентификатор кафедры.</param>
		/// <param name="teacher">Преподаватель.</param>
		public Task SetHeadAsync(Guid departmentId, Teacher teacher);
	}
}