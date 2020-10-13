using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Website.Domain.Entities;

namespace Website.Infrastructure.EntityConfigurations
{
	/// <summary>
	/// Представляет конфигурации для сущности <see cref="Teacher"/>.
	/// </summary>
	public class TeacherEntityConfiguration : PersonEntityConfiguration<Teacher>
	{
		protected override void ConfigureEntity(EntityTypeBuilder<Teacher> builder)
		{
			builder.HasOne(x => x.Department)
				   .WithMany(x => x.Teachers)
				   .HasForeignKey(x => x.DepartmentId);
		}
	}
}