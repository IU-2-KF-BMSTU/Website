using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Website.Domain.DataSources.Teachers;
using Website.Domain.DataSources.Teachers.Filters;
using Website.Domain.Entities;

namespace Website.Infrastructure.DataSources
{
	///<inheritdoc/>
	internal class TeacherDataSource : ITeacherDataSource
	{
		private readonly WebsiteDbContext _websiteDbContext;

		public TeacherDataSource(WebsiteDbContext websiteDbContext)
		{
			_websiteDbContext = websiteDbContext ?? throw new ArgumentNullException(nameof(websiteDbContext));
		}

		///<inheritdoc/>
		public void Add(Teacher teacher)
		{
			_websiteDbContext.Teachers.Add(teacher);
		}
		///<inheritdoc/>
		public void Remove(Guid id)
		{
			_websiteDbContext.Teachers.Remove(new Teacher { Id = id });
		}
		///<inheritdoc/>
		public async Task<Teacher> FindAsync(Guid id)
		{
			return await _websiteDbContext.Teachers.FindAsync(id);
		}
		///<inheritdoc/>
		public async Task<IEnumerable<Teacher>> FindAsync(TeacherFilterSettings filterSettings)
		{
			return await _websiteDbContext.Teachers.ApplyFilters(filterSettings).ToArrayAsync();
		}
		///<inheritdoc/>
		public void Update(Teacher teacher)
		{
			_websiteDbContext.Teachers.Update(teacher);
		}
	}

	/// <summary>
	/// Представляет методы расширения для фильтрации данных.
	/// </summary>
	static internal class TeachersFilterSettingsExtensions
	{
		/// <summary>
		/// Применяет настройки фильтрации.
		/// </summary>
		/// <param name="query">Запрос.</param>
		/// <param name="filterSettings">Настройки фильтрации.</param>
		/// <returns>Запрос.</returns>
		static public IQueryable<Teacher> ApplyFilters
		(
			this IQueryable<Teacher> query,
			TeacherFilterSettings filterSettings
		)
		{
			if (filterSettings == null)
				return query;
			if (filterSettings.DepartmentId.HasValue)
				query = query.Where(x => x.DepartmentId == filterSettings.DepartmentId.Value);
			if (filterSettings.TeachingType.HasValue)
				query = query.Where(x => x.TeachingType == filterSettings.TeachingType.Value);
			if (filterSettings.IsDepartmentHead.HasValue)
				query = query.Where(x => x.IsDepartmentHead == filterSettings.IsDepartmentHead.Value);
			return query;
		}
	}
}