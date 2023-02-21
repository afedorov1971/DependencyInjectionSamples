using DependencyInjectionSample3.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace DependencyInjectionSample3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var builder = new ServiceCollection()
				.AddSingleton<IInput, Input>()
				.AddSingleton<IOutput, Output>()
				.AddSingleton<ICalculator, Calculator>()
				.AddTransient<Runner>()
				.BuildServiceProvider();

			builder.GetRequiredService<Runner>().Run();
		}
	}
}