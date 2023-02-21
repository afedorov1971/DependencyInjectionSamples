using DependencyInjectionSample2.Interfaces;

namespace DependencyInjectionSample2
{
	internal class Calculator : ICalculator
	{
		public int Add(int x, int y) => x + y;
	}
}
