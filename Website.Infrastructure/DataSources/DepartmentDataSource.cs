using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using Website.Domain.DataSources.Departments;
using Website.Domain.DataSources.Departments.Selections;
using Website.Domain.Entities;

namespace Website.Infrastructure.DataSources
{
	///<inheritdoc/>
	internal class DepartmentDataSource : IDepartmentDataSource
	{
		private readonly WebsiteDbContext _websiteDbContext;

		public DepartmentDataSource(WebsiteDbContext websiteDbContext)
		{
			_websiteDbContext = websiteDbContext ?? throw new ArgumentNullException(nameof(websiteDbContext));
		}

		///<inheritdoc/>
		public void Add(Department department)
		{
			_websiteDbContext.Departments.Add(department);
		}
		///<inheritdoc/>
		public void Remove(Guid id)
		{
			_websiteDbContext.Departments.Remove(new Department { Id = id });
		}
		///<inheritdoc/>
		public async Task<Department> FindAsync(Guid id, DepartmentSelectionSettings selectionSettings)
		{
			return await _websiteDbContext.Departments.ApplyEntitySelection(selectionSettings)
													  .FirstOrDefaultAsync(x => x.Id == id);
		}
		///<inheritdoc/>
		public void Update(Department department)
		{
			_websiteDbContext.Departments.Update(department);
		}
	}

	/// <summary>
	/// Представляет методы расширения для реализации настроек для выполнения выборки.
	/// </summary>
	static internal class DepartmentSelectionSettingsExtensions
	{
		/// <summary>
		/// Применяет настройки выборки.
		/// </summary>
		/// <param name="query">Запрос.</param>
		/// <param name="selectionSettings">Настройки выборки.</param>
		/// <returns>Запрос.</returns>
		static public IQueryable<Department> ApplyEntitySelection
		(
			this IQueryable<Department> query,
			DepartmentSelectionSettings selectionSettings
		)
		{
			if (selectionSettings == null)
				return query;
			if (selectionSettings.IncludeTeachers)
				query = query.Include(x => x.Teachers);
			return query;
		}
	}
}