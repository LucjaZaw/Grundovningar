using Grundövningar.Enums;
using Grundövningar.Interfaces;

namespace Grundövningar.Classes
{
	public class Cat : IPet
	{
		public int Id { get; }
		public string Name { get; }
		public Animal Animal { get; }
		public string Feed { get; }

		public string Eat() => $"";
	}
}
