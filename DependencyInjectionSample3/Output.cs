using DependencyInjectionSample3.Interfaces;

namespace DependencyInjectionSample3
{
	internal class Output : IOutput
	{
		public void Write(string message) => Console.WriteLine(message);
	}
}
