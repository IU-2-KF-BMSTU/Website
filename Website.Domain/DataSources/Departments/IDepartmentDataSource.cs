using System;
using System.Threading.Tasks;
using Website.Domain.DataSources.Departments.Selections;
using Website.Domain.Entities;

namespace Website.Domain.DataSources.Departments
{
	/// <summary>
	/// Представляет источник данных сущности <see cref="Department"/>.
	/// </summary>
	public interface IDepartmentDataSource
	{
		/// <summary>
		/// Создаёт кафедру.
		/// </summary>
		/// <param name="department">Модель кафедры.</param>
		public void Add(Department department);
		/// <summary>
		/// Обновляет кафедру.
		/// </summary>
		/// <param name="department">Модель кафедры.</param>
		public void Update(Department department);
		/// <summary>
		/// Ассинхронно возвращает сущность кафедры.
		/// </summary>
		/// <param name="id">Идентификатор кафедры.</param>
		/// <param name="selectionSettings">Настройки для выполнения выборки.</param>
		/// <returns>Сущность кафедры.</returns>
		public Task<Department> FindAsync(Guid id, DepartmentSelectionSettings selectionSettings);
		/// <summary>
		/// Удаляет кафедру.
		/// </summary>
		/// <param name="id">Идентификатор кафедры.</param>
		public void Remove(Guid id);
	}
}