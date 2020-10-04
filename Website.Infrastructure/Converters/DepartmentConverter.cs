using Website.Domain.Models;
using Website.Infrastructure.Entities;

namespace Website.Infrastructure.Converters
{
	static internal class DepartmentConverter
	{
		static public DepartmentEntity CopyData(Department from, DepartmentEntity to = null)
		{
			if (to == null)
				to = new DepartmentEntity();
			to.Id = from.Id;
			to.Name = from.Name;
			to.Description = from.Description;
			return to;
		}
		static public Department Convert(DepartmentEntity departmentEntity) => new Department
		{
			Id = departmentEntity.Id,
			Name = departmentEntity.Name,
			Description = departmentEntity.Description,
		};
	}
}