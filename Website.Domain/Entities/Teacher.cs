using Website.Domain.Entities.Enums;

namespace Website.Domain.Entities
{
	/// <summary>
	/// Представляет сущность преподавателя.
	/// </summary>
	public class Teacher : Person
	{
		/// <summary>
		/// Научная степень.
		/// </summary>
		public string Degree { get; set; }
		/// <summary>
		/// Тип преподавания.
		/// </summary>
		public TeachingType TeachingType { get; set; }
	}
}