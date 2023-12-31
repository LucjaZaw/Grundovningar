﻿using Grundövningar.Enums;
using Grundövningar.Interfaces;

namespace Grundövningar.Classes
{
	public class Cat : IPet
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public Animal Animal { get; set; }
		public string Feed { get; set; }

		public string Eat() => $"Chewing on a {Feed}";
	}
}
