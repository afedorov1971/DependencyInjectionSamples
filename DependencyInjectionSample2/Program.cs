namespace DependencyInjectionSample2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var input = new Input();
			var output = new Output();
			var calculator = new Calculator();

			var runner = new Runner(input, calculator, output);
			runner.Run();
		}
	}
}