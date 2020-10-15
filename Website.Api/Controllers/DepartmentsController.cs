using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Website.Domain;
using Website.Domain.DataSources.Departments;
using Website.Domain.DataSources.Departments.Selections;
using Website.Domain.DataSources.Teachers;
using Website.Domain.DataSources.Teachers.Filters;
using Website.Domain.Entities;
using Website.Domain.Entities.Enums;

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
		private readonly ITeacherDataSource _teacherDataSource;

		public DepartmentsController(IDepartmentDataSource departmentDataSource, ITeacherDataSource teacherDataSource)
		{
			_departmentDataSource = departmentDataSource ?? throw new ArgumentNullException(nameof(departmentDataSource));
			_teacherDataSource = teacherDataSource ?? throw new ArgumentNullException(nameof(teacherDataSource));
		}

		/// <summary>
		/// Возвращает список преподавателей.
		/// </summary>
		/// <param name="teachingType">Фильтр по типу преподавания.</param>
		/// <returns>Cписок преподавателей.</returns>
		[HttpGet("Teachers")]
		public Task<IEnumerable<Teacher>> GetTeachers(TeachingType? teachingType)
		{
			return _teacherDataSource.FindAsync
			(
				new TeacherFilterSettings
				{
					DepartmentId = CodeSystem.Iu2DepartmentId,
					TeachingType = teachingType,
				}
			);
		}
		/// <summary>
		/// Возвращает заведующего кафедрой.
		/// </summary>
		/// <returns>Заведующий кафедрой.</returns>
		[HttpGet("Head")]
		public async Task<Teacher> GetHead()
		{
			return (await _teacherDataSource.FindAsync
			(
				new TeacherFilterSettings
				{
					DepartmentId = CodeSystem.Iu2DepartmentId,
					IsDepartmentHead = true
				}
			)).FirstOrDefault();
		}
		/// <summary>
		/// Возвращает информацию о кафедре.
		/// </summary>
		/// <returns>Заведующий кафедрой.</returns>
		[HttpGet]
		public Task<Department> GetDepartment()
		{
			return _departmentDataSource.FindAsync
			(
				CodeSystem.Iu2DepartmentId,
				new DepartmentSelectionSettings
				{
					IncludeTeachers = true
				}
			);
		}
	}
}