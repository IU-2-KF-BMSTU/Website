using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Website.Infrastructure.Entities;

namespace Website.Infrastructure.EntityConfigurations
{
	/// <summary>
	/// Представляет конфигурации для сущности <see cref="Department"/>.
	/// </summary>
	public class DepartmentEntityConfiguration : IEntityTypeConfiguration<DepartmentEntity>
    {
        ///<inheritdoc/>
        public void Configure(EntityTypeBuilder<DepartmentEntity> builder)
        {
            _ = builder.HasKey(t => t.Id);
            _ = builder.Property(t => t.Name).IsRequired();
			_ = builder.HasMany(x => x.TeacherRelations)
				       .WithOne(x => x.Department)
				       .HasForeignKey(x => x.DepartmentId);
        }
    }
}