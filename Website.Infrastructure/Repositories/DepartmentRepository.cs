using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Website.Domain.Abstractions.Repositories;
using Website.Domain.Models;
using Website.Domain.Models.Enums;
using Website.Infrastructure.Converters;
using Website.Infrastructure.Entities;
using Website.Infrastructure.Entities.DepartmentTeacherRelations;

namespace Website.Infrastructure.Repositories
{
	/// <summary>
	/// Представляет репозиторий для работы с кафедрой.
	/// </summary>
	internal class DepartmentRepository : IDepartmentRepository
	{
		private readonly WebsiteDbContext _websiteDbContext;

		public DepartmentRepository(WebsiteDbContext websiteDbContext)
		{
			_websiteDbContext = websiteDbContext ?? throw new ArgumentNullException(nameof(websiteDbContext));
		}

		///<inheritdoc/>
		public Task CreateDepartment(Department department)
		{
			_websiteDbContext.Departments.Add(DepartmentConverter.CopyData(department));
			return _websiteDbContext.SaveChangesAsync();
		}
		///<inheritdoc/>
		public async Task<Department> GetDepartment(Guid id)
		{
			return DepartmentConverter.Convert(await _websiteDbContext.Departments.FindAsync(id));
		}
		///<inheritdoc/>
		public async Task UpdateDepartment(Department department)
		{
			DepartmentEntity departmentEntity = await _websiteDbContext.Departments.FindAsync(department.Id);
			_websiteDbContext.Departments.Update(DepartmentConverter.CopyData(department, departmentEntity));
			await _websiteDbContext.SaveChangesAsync();
		}
		///<inheritdoc/>
		public Task AddTeacher(Guid departmentId, Guid teacherId, DepartmentTeacherRelation departmentTeacherRelation)
		{
			DepartmentTeacherRelationEntity departmentTeacherRelationEntity = new DepartmentTeacherRelationEntity
			{
				Id = departmentTeacherRelation.Id,
				TeachingType = departmentTeacherRelation.TeachingType,
				IsDepartmentHead = departmentTeacherRelation.IsDepartmentHead,
				TeacherId = teacherId,
				DepartmentId = departmentId
			};
			_websiteDbContext.DepartmentTeacherRelations.Add(departmentTeacherRelationEntity);
			return _websiteDbContext.SaveChangesAsync();
		}
		///<inheritdoc/>
		public async Task<IEnumerable<Teacher>> GetTeachers(Guid departmentId, TeachingType? teachingType)
		{
			IQueryable<DepartmentTeacherRelationEntity> query;
			query = _websiteDbContext.DepartmentTeacherRelations.Where(x => x.DepartmentId == departmentId);
			if (teachingType.HasValue)
				query = query.Where(x => x.TeachingType == teachingType.Value);
			return (await query.Select(x => x.Teacher).ToArrayAsync()).Select(x => TeacherConverter.Convert(x));
		}
		///<inheritdoc/>
		public async Task<Teacher> GetHead(Guid departmentId)
		{
			TeacherEntity teacherEntity = await _websiteDbContext.DepartmentTeacherRelations.Where(x => x.DepartmentId == departmentId)
																							.Where(x => x.IsDepartmentHead == true)
																							.Include(x => x.Teacher)
																							.Select(x => x.Teacher)
																							.FirstOrDefaultAsync();
			return TeacherConverter.Convert(teacherEntity);
		}
	}
}