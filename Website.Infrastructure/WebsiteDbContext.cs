using Microsoft.EntityFrameworkCore;
using Website.Infrastructure.Entities;
using Website.Infrastructure.Entities.DepartmentTeacherRelations;

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
        /// Таблица преподавателей.
        /// </summary>
        public DbSet<TeacherEntity> Teachers { get; set; }
        /// <summary>
        /// Таблица вопросов.
        /// </summary>
        public DbSet<QuestionEntity> Questions { get; set; }
        /// <summary>
        /// Таблица медиаконтента.
        /// </summary>
        public DbSet<MediaContentEntity> MediaContents { get; set; }
        /// <summary>
        /// Таблица кафедр.
        /// </summary>
        public DbSet<DepartmentEntity> Departments { get; set; }
        /// <summary>
        /// Таблица отношений преподавателя с кафедрами.
        /// </summary>
        public DbSet<DepartmentTeacherRelationEntity> DepartmentTeacherRelations{ get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
            modelBuilder.EnsureDataInitialization();
        }
	}
}