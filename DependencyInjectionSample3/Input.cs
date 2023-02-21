using DependencyInjectionSample3.Interfaces;

namespace DependencyInjectionSample3
{
	internal class Input : IInput
	{
		public string? Read() => Console.ReadLine();
	}
}
