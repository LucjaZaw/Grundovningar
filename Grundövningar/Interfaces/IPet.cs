using Grundövningar.Enums;

namespace Grundövningar.Interfaces
{
	public interface IPet
	{
		int Id { get; }
		string Name { get; }
		Animal Animal { get; }
		string Feed {  get; }

		public string Eat();
	}
}
