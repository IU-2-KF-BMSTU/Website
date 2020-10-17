using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Website.Domain.Entities;

namespace Website.Infrastructure.EntityConfigurations
{
	/// <summary>
	/// Представляет конфигурации для сущности <see cref="News"/>.
	/// </summary>
	public class NewsEntityConfiguration : IEntityTypeConfiguration<News>
	{
		///<inheritdoc/>
		public void Configure(EntityTypeBuilder<News> builder)
		{
			_ = builder.HasKey(t => t.Id);
			_ = builder.Property(t => t.Title).IsRequired();
			_ = builder.Property(t => t.Content).IsRequired();
		}
	}
}