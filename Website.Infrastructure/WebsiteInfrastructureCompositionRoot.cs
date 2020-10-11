using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Website.Domain.Abstractions.Repositories;
using Website.Infrastructure.Repositories;

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
			serviceCollection.AddScoped<IQuestionRepository, QuestionRepository>();
		}
		static private void AddDatabase(this IServiceCollection serviceCollection, IConfiguration configuration)
		{
			serviceCollection.AddEntityFrameworkNpgsql();
			serviceCollection.AddDbContext<WebsiteDbContext>(options =>
			{
				string connectionString = configuration["Storage:ConnectionString"];
				string assemplyName = typeof(WebsiteDbContext).Assembly.GetName().Name;
				options.UseNpgsql(connectionString, npgsqlOptions => { npgsqlOptions.MigrationsAssembly(assemplyName); });
			});
		}
	}
}