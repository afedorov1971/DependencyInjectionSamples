using DependencyInjectionSample2.Interfaces;

namespace DependencyInjectionSample2
{
	internal class Input : IInput
	{
		public string? Read() => Console.ReadLine();
	}
}
