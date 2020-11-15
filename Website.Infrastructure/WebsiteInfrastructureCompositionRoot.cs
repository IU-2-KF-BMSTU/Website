using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using Website.Domain.DataSources;
using Website.Domain.DataSources.Departments;
using Website.Domain.DataSources.NewsDS;
using Website.Domain.DataSources.Teachers;
using Website.Infrastructure.DataSources;

namespace Website.Infrastructure
{
	/// <summary>
	/// Представляет класс с методами, предназначенные для добавления уровня инфраструктуры.
	/// </summary>
	static public class WebsiteInfrastructureCompositionRoot
	{
		/// <summary>
		/// Добавляет сервисы уровня инфраструктуры.
		/// </summary>
		/// <param name="serviceCollection">Коллекция сервисов.</param>
		/// <param name="configuration">Конфигурации приложения.</param>
		static public void AddWebsiteInfrastructure(this IServiceCollection serviceCollection, IConfiguration configuration)
		{
			serviceCollection.AddRepositories();
			serviceCollection.AddDatabase(configuration);
		}

		static private void AddRepositories(this IServiceCollection serviceCollection)
		{
			serviceCollection.AddScoped<IDepartmentDataSource, DepartmentDataSource>();
			serviceCollection.AddScoped<IMediaContentDataSource, MediaContentDataSource>();
			serviceCollection.AddScoped<IQuestionDataSource, QuestionDataSource>();
			serviceCollection.AddScoped<ITeacherDataSource, TeacherDataSource>();
			serviceCollection.AddScoped<INewsDataSource, NewsDataSource>();
		}
		static private void AddDatabase(this IServiceCollection serviceCollection, IConfiguration configuration)
		{
			Console.WriteLine(Environment.GetEnvironmentVariable("DbConnectionString"));
			serviceCollection.AddEntityFrameworkNpgsql();
			serviceCollection.AddDbContext<WebsiteDbContext>(options =>
			{
				string connectionString = Environment.GetEnvironmentVariable("DbConnectionString");
				string assemplyName = typeof(WebsiteDbContext).Assembly.GetName().Name;
				options.UseNpgsql(connectionString, npgsqlOptions => { npgsqlOptions.MigrationsAssembly(assemplyName); });
			});
		}
	}
}