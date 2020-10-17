using Microsoft.EntityFrameworkCore;
using Website.Domain.Entities;

namespace Website.Infrastructure
{
	/// <summary>
	/// Представляет контекст для доступа к данным в базе данных.
	/// </summary>
	public class WebsiteDbContext : DbContext
	{
		public WebsiteDbContext(DbContextOptions<WebsiteDbContext> options) : base(options)
		{
			Database.Migrate();
		}

		/// <summary>
		/// Таблица преподавателей.
		/// </summary>
		public DbSet<Teacher> Teachers { get; set; }
		/// <summary>
		/// Таблица вопросов.
		/// </summary>
		public DbSet<Question> Questions { get; set; }
		/// <summary>
		/// Таблица медиаконтента.
		/// </summary>
		public DbSet<MediaContent> MediaContents { get; set; }
		/// <summary>
		/// Таблица кафедр.
		/// </summary>
		public DbSet<Department> Departments { get; set; }
		/// <summary>
		/// Таблица новостей.
		/// </summary>
		public DbSet<News> News { get; set; }

		///<inheritdoc/>
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
			modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
			new DataInitializer().EnsureDataInitialization(modelBuilder);
		}
	}
}