using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Website.Domain.Entities;

namespace Website.Infrastructure.EntityConfigurations
{
	/// <summary>
	/// Представляет конфигурации для сущности <see cref="Person"/>.
	/// </summary>
	public abstract class PersonEntityConfiguration<TPerson> : IEntityTypeConfiguration<TPerson> 
		where TPerson : Person
	{
		///<inheritdoc/>
		public void Configure(EntityTypeBuilder<TPerson> builder)
		{
			_ = builder.HasKey(x => x.Id);
			_ = builder.Property(x => x.Surname).IsRequired();
			_ = builder.Property(x => x.Name).IsRequired();

			ConfigureEntity(builder);
		}
		protected abstract void ConfigureEntity(EntityTypeBuilder<TPerson> builder);
	}
}