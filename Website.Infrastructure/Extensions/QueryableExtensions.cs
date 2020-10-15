using System;
using System.Linq;

namespace Website.Infrastructure.Extensions
{
	/// <summary>
	/// Представляет методы расширения для <see cref="IQueryable"/>.
	/// </summary>
	static internal class QueryableExtensions
	{
		static internal IQueryable<T> ApplyPagingOption<T>(this IQueryable<T> query, int offset, int count)
		{
			if (offset < 0)
				throw new ArgumentOutOfRangeException(nameof(offset));
			if (count < 0)
				throw new ArgumentOutOfRangeException(nameof(count));
			return query.Skip(offset).Take(count);
		}
	}
}