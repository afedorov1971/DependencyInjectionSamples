using DependencyInjectionSample2;
using DependencyInjectionSample2.Interfaces;
using FluentAssertions;
using Moq;
using Moq.Sequences;

namespace DependencyInjectionSample2Tests
{
	public class Tests
	{
		[SetUp]
		public void Setup()
		{
		}

		[Test]
		public void RunnerTest()
		{
			var input = new Mock<IInput>(MockBehavior.Strict);
			var output = new Mock<IOutput>(MockBehavior.Strict);
			var calculator = new Mock<ICalculator>(MockBehavior.Strict);

			input.SetupSequence(x => x.Read())
				.Returns("2 3")
				.Returns(string.Empty);

			calculator.Setup(x => x.Add( It.IsAny<int>(), It.IsAny<int>())).Returns<int,int>((x,y) => x + y);

			using (Sequence.Create())
			{
				output.Setup(x => x.Write("Для вычисления суммы введите два числа, разделенных пробелом и нажмите Enter. Для завершения работы просто нажмите Enter")).InSequence();
				output.Setup(x => x.Write("2 + 3 = 5")).InSequence();
				output.Setup(x => x.Write("Работа завершена")).InSequence();

				var runner = new Runner(input.Object, calculator.Object, output.Object);
				runner.Run();
			}
		}

		[TestCase(1,2)]
		[TestCase(-1, 1)]
		public void CalculatorTest(int x, int y)
		{
			var calculator = new Calculator();
			calculator.Add(x, y).Should().Be(x + y);
		}
	}
}