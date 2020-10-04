using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Common
{
	/// <inheritdoc/>
	public class ExceptionsFilter : IExceptionFilter
	{
		private readonly ILogger<ExceptionsFilter> _logger;
		private readonly IHostEnvironment _hostingEnvironment;

		/// <summary/>
		public ExceptionsFilter(ILogger<ExceptionsFilter> logger, IHostEnvironment hostingEnvironment)
		{
			_logger = logger;
			_hostingEnvironment = hostingEnvironment;
		}

		/// <inheritdoc />
		public void OnException(ExceptionContext context)
		{
			_logger.LogError(context.Exception, "Ошибка выполнения запроса");

			object result;
			if (!_hostingEnvironment.IsProduction())
			{
				result = new
				{
					error = true,
					message = context.Exception.Message,
					stackTrace = context.Exception.StackTrace
				};
			}
			else
			{
				result = new
				{
					error = true,
					message = context.Exception.Message,
				};
			}

			context.Result = new JsonResult(result);
			context.HttpContext.Response.StatusCode = 500;

			context.ExceptionHandled = true;
		}
	}
}