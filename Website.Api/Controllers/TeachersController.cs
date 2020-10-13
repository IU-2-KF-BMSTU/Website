using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Website.Api.Models.Teachers;
using Website.Domain;
using Website.Domain.DataSources;
using Website.Domain.Entities;
using Website.Infrastructure;

namespace Website.Api.Controllers
{
	/// <summary>
	/// Представляет API для работы с кафедрой.
	/// </summary>
	[Route("[controller]")]
	[ApiController]
	public class TeachersController : ControllerBase
	{
		private readonly IDepartmentDataSource _departmentDataSource;
		private readonly ITeacherDataSource _teacherDataSource;
		private readonly WebsiteDbContext _websiteDbContext;

		public TeachersController(IDepartmentDataSource departmentDataSource, ITeacherDataSource teacherDataSource, WebsiteDbContext websiteDbContext)
		{
			_departmentDataSource = departmentDataSource ?? throw new ArgumentNullException(nameof(departmentDataSource));
			_teacherDataSource = teacherDataSource ?? throw new ArgumentNullException(nameof(teacherDataSource));
			_websiteDbContext = websiteDbContext ?? throw new ArgumentNullException(nameof(websiteDbContext));
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
				PictureId = teacherFm.PictureId
			};
			await _teacherDataSource.CreateTeacherAsync(teacher);
			await _departmentDataSource.AddTeacherAsync(CodeSystem.Iu2DepartmentId, teacher);
			await _websiteDbContext.SaveChangesAsync();
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
			return _teacherDataSource.UpdateTeacherAsync(teacher);
		}
		/// <summary>
		/// Удаляет преподавателя.
		/// </summary>
		/// <param name="id">Идентификатор преподавателя.</param>
		[HttpDelete("{id}")]
		public Task DeleteTeacher(Guid id)
		{
			return _teacherDataSource.DeleteTeacherAsync(id);
		}
		/// <summary>
		/// Возвращает преподавателя.
		/// </summary>
		/// <param name="id">Идентификатор преподавателя.</param>
		[HttpGet("{id}")]
		public Task<Teacher> GetTeacher(Guid id)
		{
			return _teacherDataSource.GetTeacherAsync(id);
		}
	}
}