using DependencyInjectionSample2.Interfaces;

namespace DependencyInjectionSample2
{
	internal class Output : IOutput
	{
		public void Write(string message) => Console.WriteLine(message);
	}
}
