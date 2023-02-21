using DependencyInjectionSample3.Interfaces;

namespace DependencyInjectionSample3
{
	internal class Calculator : ICalculator
	{
		public int Add(int x, int y) => x + y;
	}
}
