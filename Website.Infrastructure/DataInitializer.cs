using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using Website.Domain;
using Website.Domain.Models.Enums;
using Website.Infrastructure.Entities;
using Website.Infrastructure.Entities.DepartmentTeacherRelations;

namespace Website.Infrastructure
{
	static public class DataInitializer
	{
		static public void EnsureDataInitialization(this ModelBuilder modelBuilder)
		{
			DepartmentEntity iu2Department = GetDepartment();
			TeacherEntity departmentHead = GetDepartmentHead();
			TeacherEntity[] teachers = GetTeachers();

			DepartmentTeacherRelationEntity[] departmentTeacherRelations = new DepartmentTeacherRelationEntity[teachers.Length];
			for (int i = 0; i < teachers.Length; i++)
			{
				departmentTeacherRelations[i] = new DepartmentTeacherRelationEntity
				{
					Id = Guid.NewGuid(),
					DepartmentId = iu2Department.Id,
					TeacherId = teachers[i].Id,
					TeachingType = TeachingType.Regular
				};
			}
			DepartmentTeacherRelationEntity departmentHeadRelation = new DepartmentTeacherRelationEntity
			{
				Id = Guid.NewGuid(),
				DepartmentId = iu2Department.Id,
				TeacherId = departmentHead.Id,
				TeachingType = TeachingType.Regular,
				IsDepartmentHead = true
			};

			List<TeacherEntity> allTeachers = teachers.ToList();
			allTeachers.Add(departmentHead);
			modelBuilder.Entity<TeacherEntity>().HasData(allTeachers);

			List<DepartmentTeacherRelationEntity> alldepartmentTeacherRelations = departmentTeacherRelations.ToList();
			alldepartmentTeacherRelations.Add(departmentHeadRelation);
			modelBuilder.Entity<DepartmentTeacherRelationEntity>().HasData(alldepartmentTeacherRelations);

			modelBuilder.Entity<DepartmentEntity>().HasData(new DepartmentEntity[] { iu2Department });
		}

		static private DepartmentEntity GetDepartment()
		{
			return new DepartmentEntity
			{
				Id = CodeSystem.Iu2DepartmentId,
				Name = "ИУ-2 КФ",
			};
		}
		static private TeacherEntity GetDepartmentHead()
		{
			return new TeacherEntity
			{
				Id = Guid.NewGuid(),
				Name = "Игорь",
				Surname = "Чухраев",
				Patronymic = "Владимирович",
				Degree = "кандидат технических наук, доцент"
			};
		}
		static private TeacherEntity[] GetTeachers()
		{
			return new TeacherEntity[]
			{
				new TeacherEntity
				{
					Id = Guid.NewGuid(),
					Name = "Борсук",
					Surname = "Наталья",
					Patronymic = "Александровна",
					Degree = "кандидат технических наук, доцент"
				},
				new TeacherEntity
				{
					Id = Guid.NewGuid(),
					Name = "Дерюгина",
					Surname = "Елена",
					Patronymic = "Олеговна",
					Degree = "кандидат технических наук, доцент"
				},
			};
		}
	}
}
