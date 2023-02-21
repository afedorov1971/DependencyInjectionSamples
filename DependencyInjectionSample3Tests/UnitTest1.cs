using DependencyInjectionSample3;
using DependencyInjectionSample3.Interfaces;
using FluentAssertions;
using Microsoft.Extensions.DependencyInjection;

namespace DependencyInjectionSample3Tests
{
	public class Tests
	{
		[SetUp]
		public void Setup()
		{
		}

		[Test]
		public void CreateInstancesTest()
		{
			var builder = new ServiceCollection()
				.AddSingleton<IInput, Input>()
				.AddSingleton<IOutput, Output>()
				.AddSingleton<ICalculator, Calculator>()
				.AddTransient<Runner>()
				.BuildServiceProvider();

			var i1 = builder.GetRequiredService<IInput>();
			var i2 = builder.GetRequiredService<IInput>();

			i1.Should().BeSameAs(i2);

			var r1 = builder.GetRequiredService<Runner>();
			var r2 = builder.GetRequiredService<Runner>();

			r1.Should().NotBeSameAs(r2);
		}
	}
}