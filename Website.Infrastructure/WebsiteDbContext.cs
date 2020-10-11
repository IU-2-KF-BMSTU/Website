using Microsoft.EntityFrameworkCore;
using Website.Domain.Entities;

namespace Website.Infrastructure
{
    /// <summary>
    /// Представляет контекст для доступа к данным в базе данных.
    /// </summary>
    internal class WebsiteDbContext : DbContext
    {
        public WebsiteDbContext(DbContextOptions<WebsiteDbContext> options) : base(options)
        {
            Database.Migrate();
        }

        /// <summary>
        /// Таблица вопросов.
        /// </summary>
        public DbSet<Question> Questions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        }
	}
}