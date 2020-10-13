using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Website.Domain;
using Website.Domain.DataSources;
using Website.Domain.Entities;
using Website.Domain.Entities.Enums;
using Website.Infrastructure;

namespace Website.Api.Controllers
{
	/// <summary>
	/// Представляет API для работы с кафедрой.
	/// </summary>
	[Route("[controller]")]
	[ApiController]
	public class DepartmentsController : ControllerBase
	{
		private readonly IDepartmentDataSource _departmentDataSource;

		public DepartmentsController(IDepartmentDataSource departmentDataSource)
		{
			_departmentDataSource = departmentDataSource ?? throw new ArgumentNullException(nameof(departmentDataSource));
		}

		/// <summary>
		/// Возвращает список преподавателей.
		/// </summary>
		/// <param name="teachingType">Фильтр по типу преподавания.</param>
		/// <returns>Cписок преподавателей.</returns>
		[HttpGet("Teachers")]
		public Task<IEnumerable<Teacher>> GetTeachers(TeachingType? teachingType)
		{
			return _departmentDataSource.GetTeachersAsync(CodeSystem.Iu2DepartmentId, teachingType);
		}
		/// <summary>
		/// Возвращает заведующего кафедрой.
		/// </summary>
		/// <returns>Заведующий кафедрой.</returns>
		[HttpGet("Head")]
		public Task<Teacher> GetHead()
		{
			return _departmentDataSource.GetHeadAsync(CodeSystem.Iu2DepartmentId);
		}
		/// <summary>
		/// Возвращает информацию о кафедре.
		/// </summary>
		/// <returns>Заведующий кафедрой.</returns>
		[HttpGet]
		public Task<Department> GetDepartment()
		{
			return _departmentDataSource.GetDepartmentAsync(CodeSystem.Iu2DepartmentId);
		}
	}
}