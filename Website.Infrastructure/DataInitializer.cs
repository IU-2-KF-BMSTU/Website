using Microsoft.EntityFrameworkCore;
using System;
using Website.Domain;
using Website.Domain.Entities;

namespace Website.Infrastructure
{
	/// <summary>
	/// Представляет инициализатор данных.
	/// </summary>
	public class DataInitializer
	{
		/// <summary>
		/// Обеспечивает базовую инициализацию данных.
		/// </summary>
		/// <param name="modelBuilder"></param>
		public void EnsureDataInitialization(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Department>().HasData(InitializeDepartment());
			modelBuilder.Entity<Teacher>().HasData(InitializeTeachers());
		}

		private Department InitializeDepartment() => new Department
		{
			Id = CodeSystem.Iu2DepartmentId,
			Name = "ИУ-2 КФ",
			Description = "Описание кафедры"
		};
		private Teacher[] InitializeTeachers() => new Teacher[]
		{
			new Teacher
			{
				Id = Guid.NewGuid(),
				Name = "Игорь",
				Surname = "Чухраев",
				Patronymic = "Владимирович",
				Degree = "кандидат технических наук, доцент",
				IsDepartmentHead = true,
				DepartmentId = CodeSystem.Iu2DepartmentId
			},
			new Teacher
			{
				Id = Guid.NewGuid(),
				Name = "Борсук",
				Surname = "Наталья",
				Patronymic = "Александровна",
				Degree = "кандидат технических наук, доцент",
				DepartmentId = CodeSystem.Iu2DepartmentId
			},
			new Teacher
			{
				Id = Guid.NewGuid(),
				Name = "Дерюгина",
				Surname = "Елена",
				Patronymic = "Олеговна",
				Degree = "кандидат технических наук, доцент",
				DepartmentId = CodeSystem.Iu2DepartmentId
			},
		};
	}
}