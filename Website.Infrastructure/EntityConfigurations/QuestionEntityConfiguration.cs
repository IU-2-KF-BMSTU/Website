using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Website.Domain.Entities;

namespace Website.Infrastructure.EntityConfigurations
{
	/// <summary>
	/// Представляет конфигурации для сущности <see cref="Question"/>.
	/// </summary>
	public class QuestionEntityConfiguration : IEntityTypeConfiguration<Question>
	{
		///<inheritdoc/>
		public void Configure(EntityTypeBuilder<Question> builder)
		{
			_ = builder.HasKey(t => t.Id);
			_ = builder.Property(k => k.Contact).IsRequired();
			_ = builder.Property(k => k.Content).IsRequired();
		}
	}
}