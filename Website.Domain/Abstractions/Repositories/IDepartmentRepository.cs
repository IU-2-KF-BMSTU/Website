using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Website.Domain.Models;
using Website.Domain.Models.Enums;

namespace Website.Domain.Abstractions.Repositories
{
	/// <summary>
	/// Представляет репозиторий для работы с кафедрой.
	/// </summary>
	public interface IDepartmentRepository
	{
		/// <summary>
		/// Создаёт кафедру.
		/// </summary>
		/// <param name="department">Модель кафедры.</param>
		public Task CreateDepartment(Department department);
		/// <summary>
		/// Обновляет кафедру.
		/// </summary>
		/// <param name="department">Модель кафедры.</param>
		public Task UpdateDepartment(Department department);
		/// <summary>
		/// Возвращает сущность кафедры.
		/// </summary>
		/// <param name="id">Идентификатор кафедры.</param>
		/// <returns>Сущность кафедры.</returns>
		public Task<Department> GetDepartment(Guid id);

		/// <summary>
		/// Добавляет преподавателя на кафедру.
		/// </summary>
		/// <param name="departmentId">Идентификатор кафедры.</param>
		/// <param name="teacherId">Идентификатор преподавателя.</param>
		/// <param name="departmentTeacherRelation">Модель связи преподавателя с кафедрой.</param>
		public Task AddTeacher(Guid departmentId, Guid teacherId, DepartmentTeacherRelation departmentTeacherRelation);
		/// <summary>
		/// Возвращает список преподавателей.
		/// </summary>
		/// <param name="departmentId">Идентификатор кафедры.</param>
		/// <param name="teachingType">Фильтр по типу преподавания.</param>
		/// <returns>Список преподавателей.</returns>
		public Task<IEnumerable<Teacher>> GetTeachers(Guid departmentId, TeachingType? teachingType);
		/// <summary>
		/// Возвращает заведующего кафедрой.
		/// </summary>
		/// <param name="departmentId">Идентификатор кафедры.</param>
		/// <returns>Заведующий кафедрой.</returns>
		public Task<Teacher> GetHead(Guid departmentId);
	}
}