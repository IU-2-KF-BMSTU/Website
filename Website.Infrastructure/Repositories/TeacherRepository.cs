using System;
using System.Threading.Tasks;
using Website.Domain.Abstractions.Repositories;
using Website.Domain.Models;
using Website.Infrastructure.Converters;
using Website.Infrastructure.Entities;

namespace Website.Infrastructure.Repositories
{
	/// <summary>
	/// Представляет репозиторий для работы с преподавателями.
	/// </summary>
	internal class TeacherRepository : ITeacherRepository
	{
		private readonly WebsiteDbContext _websiteDbContext;

		public TeacherRepository(WebsiteDbContext websiteDbContext)
		{
			_websiteDbContext = websiteDbContext ?? throw new ArgumentNullException(nameof(websiteDbContext));
		}

		///<inheritdoc/>
		public Task CreateTeacher(Teacher teacher)
		{
			_websiteDbContext.Teachers.Add(TeacherConverter.CopyData(teacher));
			return _websiteDbContext.SaveChangesAsync();
		}
		///<inheritdoc/>
		public async Task UpdateTeacher(Teacher teacher)
		{
			TeacherEntity teacherEntity = await _websiteDbContext.Teachers.FindAsync(teacher.Id);
			_websiteDbContext.Teachers.Update(TeacherConverter.CopyData(teacher, teacherEntity));
			await _websiteDbContext.SaveChangesAsync();
		}
		///<inheritdoc/>
		public async Task<Teacher> GetTeacher(Guid id)
		{
			return TeacherConverter.Convert(await _websiteDbContext.Teachers.FindAsync(id));
		}

		public async Task DeleteTeacher(Guid id)
		{
			TeacherEntity teacherEntity = await _websiteDbContext.Teachers.FindAsync(id);
			_websiteDbContext.Teachers.Remove(teacherEntity);
			await _websiteDbContext.SaveChangesAsync();
		}
	}
}