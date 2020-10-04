using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Website.Domain;
using Website.Domain.Abstractions.Repositories;
using Website.Domain.Models;
using Website.Domain.Models.Enums;

namespace Website.Api.Controllers
{
	/// <summary>
	/// Представляет API для работы с кафедрой.
	/// </summary>
	[Route("[controller]")]
	[ApiController]
	public class DepartmentsController : ControllerBase
	{
		private readonly IDepartmentRepository _departmentRepository;
		private readonly ITeacherRepository _teacherRepository;

		public DepartmentsController(IDepartmentRepository departmentRepository, ITeacherRepository teacherRepository)
		{
			_departmentRepository = departmentRepository ?? throw new ArgumentNullException(nameof(departmentRepository));
			_teacherRepository = teacherRepository ?? throw new ArgumentNullException(nameof(teacherRepository));
		}
		
		/// <summary>
		/// Возвращает список преподавателей.
		/// </summary>
		/// <param name="teachingType">Фильтр по типу преподавания.</param>
		/// <returns>Cписок преподавателей.</returns>
		[HttpGet("Teachers")]
		public Task<IEnumerable<Teacher>> GetTeachers(TeachingType? teachingType)
		{
			return _departmentRepository.GetTeachers(CodeSystem.Iu2DepartmentId, teachingType);
		}
		/// <summary>
		/// Возвращает заведующего кафедрой.
		/// </summary>
		/// <returns>Заведующий кафедрой.</returns>
		[HttpGet("Head")]
		public Task<Teacher> GetHead()
		{
			return _departmentRepository.GetHead(CodeSystem.Iu2DepartmentId);
		}
		/// <summary>
		/// Возвращает информацию о кафедре.
		/// </summary>
		/// <returns>Заведующий кафедрой.</returns>
		[HttpGet]
		public Task<Department> GetDepartment()
		{
			return _departmentRepository.GetDepartment(CodeSystem.Iu2DepartmentId);
		}
	}
}