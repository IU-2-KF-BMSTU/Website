using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Website.Infrastructure.Entities;
using Website.Infrastructure.Entities.DepartmentTeacherRelations;

namespace Website.Infrastructure.EntityConfigurations
{
	/// <summary>
	/// Представляет конфигурации для сущности <see cref="DepartmentTeacherRelation"/>.
	/// </summary>
	public class DepartmentTeacherRelationEntityConfiguration : IEntityTypeConfiguration<DepartmentTeacherRelationEntity>
    {
        ///<inheritdoc/>
        public void Configure(EntityTypeBuilder<DepartmentTeacherRelationEntity> builder)
        {
            _ = builder.HasKey(t => t.Id);
            _ = builder.HasOne(x => x.Teacher)
                       .WithOne(x => x.DepartmentRelation)
                       .HasForeignKey<TeacherEntity>(x => x.DepartmentRelationId);
        }
    }
}