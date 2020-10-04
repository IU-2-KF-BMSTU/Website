using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Website.Infrastructure.Entities;

namespace Website.Infrastructure.EntityConfigurations
{
	/// <summary>
	/// Представляет конфигурации для сущности <see cref="MediaContent"/>.
	/// </summary>
	public class MediaContentEntityConfiguration : IEntityTypeConfiguration<MediaContentEntity>
    {
        ///<inheritdoc/>
        public void Configure(EntityTypeBuilder<MediaContentEntity> builder)
        {
            _ = builder.HasKey(t => t.Id);
            _ = builder.Property(k => k.ContentType).IsRequired();
            _ = builder.Property(k => k.Content).IsRequired();
        }
    }
}