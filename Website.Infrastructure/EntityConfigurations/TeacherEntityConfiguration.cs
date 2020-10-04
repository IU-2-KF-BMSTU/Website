using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Website.Infrastructure.Entities;
using Website.Infrastructure.Entities.DepartmentTeacherRelations;

namespace Website.Infrastructure.EntityConfigurations
{
	/// <summary>
	/// Представляет конфигурации для сущности <see cref="Teacher"/>.
	/// </summary>
	public class TeacherEntityConfiguration : IEntityTypeConfiguration<TeacherEntity>
    {
        ///<inheritdoc/>
        public void Configure(EntityTypeBuilder<TeacherEntity> builder)
        {
            _ = builder.HasKey(t => t.Id);
            _ = builder.HasOne(x => x.DepartmentRelation)
                       .WithOne(x => x.Teacher)
                       .HasForeignKey<DepartmentTeacherRelationEntity>(x => x.TeacherId)
                       .OnDelete(DeleteBehavior.Cascade);
        }
    }
}