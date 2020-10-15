using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Website.Domain.Entities;

namespace Website.Infrastructure.EntityConfigurations
{
	/// <summary>
	/// Представляет конфигурации для сущности <see cref="Department"/>.
	/// </summary>
	public class DepartmentEntityConfiguration : IEntityTypeConfiguration<Department>
	{
		///<inheritdoc/>
		public void Configure(EntityTypeBuilder<Department> builder)
		{
			_ = builder.HasKey(t => t.Id);
			_ = builder.Property(t => t.Name).IsRequired();
		}
	}
}