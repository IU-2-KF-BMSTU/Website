using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Website.Api.Models.Teachers;
using Website.Domain;
using Website.Domain.Abstractions.Repositories;
using Website.Domain.Models;

namespace Website.Api.Controllers
{
	/// <summary>
	/// Представляет API для работы с кафедрой.
	/// </summary>
	[Route("[controller]")]
	[ApiController]
	public class TeachersController : ControllerBase
	{
		private readonly IDepartmentRepository _departmentRepository;
		private readonly ITeacherRepository _teacherRepository;

		public TeachersController(IDepartmentRepository departmentRepository, ITeacherRepository teacherRepository)
		{
			_departmentRepository = departmentRepository ?? throw new ArgumentNullException(nameof(departmentRepository));
			_teacherRepository = teacherRepository ?? throw new ArgumentNullException(nameof(teacherRepository));
		}

		/// <summary>
		/// Создаёт и добавляет преподавателя на кафедру ИУ-2.
		/// </summary>
		/// <param name="teacherFm">Модель преподавателя.</param>
		/// <returns>Идентификатор преподавателя.</returns>
		[HttpPost]
		public async Task<Guid> CreateTeacher([FromBody] TeacherFm teacherFm)
		{
			Teacher teacher = new Teacher
			{
				Id = Guid.NewGuid(),
				Surname = teacherFm.Surname,
				Name = teacherFm.Name,
				Patronymic = teacherFm.Patronymic,
				Degree = teacherFm.Degree,
				AdditionalInfo = teacherFm.AdditionalInfo,
				PictureId = teacherFm.PictureId,
			};
			DepartmentTeacherRelation departmentTeacherRelation = new DepartmentTeacherRelation
			{
				Id = Guid.NewGuid(),
				TeachingType = teacherFm.TeachingType,
				IsDepartmentHead = false
			};
			await _teacherRepository.CreateTeacher(teacher);
			await _departmentRepository.AddTeacher(CodeSystem.Iu2DepartmentId, teacher.Id, departmentTeacherRelation);
			return teacher.Id;
		}
		/// <summary>
		/// Обновляет информацию преподавателя.
		/// </summary>
		/// <param name="teacherVm">Модель преподавателя.</param>
		[HttpPut]
		public Task UpdateTeacher([FromBody] TeacherVm teacherVm)
		{
			Teacher teacher = new Teacher
			{
				Id = teacherVm.Id,
				Surname = teacherVm.Surname,
				Name = teacherVm.Name,
				Patronymic = teacherVm.Patronymic,
				Degree = teacherVm.Degree,
				AdditionalInfo = teacherVm.AdditionalInfo,
				PictureId = teacherVm.PictureId,
			};
			return _teacherRepository.UpdateTeacher(teacher);
		}
		/// <summary>
		/// Удаляет преподавателя.
		/// </summary>
		/// <param name="id">Идентификатор преподавателя.</param>
		[HttpDelete("{id}")]
		public Task DeleteTeacher(Guid id)
		{
			return _teacherRepository.DeleteTeacher(id);
		}
		/// <summary>
		/// Возвращает преподавателя.
		/// </summary>
		/// <param name="id">Идентификатор преподавателя.</param>
		[HttpGet("{id}")]
		public Task<Teacher> GetTeacher(Guid id)
		{
			return _teacherRepository.GetTeacher(id);
		}
	}
}