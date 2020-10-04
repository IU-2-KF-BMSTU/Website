using Website.Domain.Models;
using Website.Infrastructure.Entities;

namespace Website.Infrastructure.Converters
{
	static internal class TeacherConverter
	{
		static public TeacherEntity CopyData(Teacher from, TeacherEntity to = null)
		{
			if (to == null)
				to = new TeacherEntity();
			to.Id = from.Id;
			to.Surname = from.Surname;
			to.Name = from.Name;
			to.Patronymic = from.Patronymic;
			to.Degree = from.Degree;
			to.AdditionalInfo = from.AdditionalInfo;
			to.PictureId = from.PictureId;
			return to;
		}
		static public Teacher Convert(TeacherEntity teacherEntity) => new Teacher
		{
			Id = teacherEntity.Id,
			Surname = teacherEntity.Surname,
			Name = teacherEntity.Name,
			Patronymic = teacherEntity.Patronymic,
			Degree = teacherEntity.Degree,
			AdditionalInfo = teacherEntity.AdditionalInfo,
			PictureId = teacherEntity.PictureId
		};
	}
}