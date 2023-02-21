using DependencyInjectionSample2.Interfaces;

namespace DependencyInjectionSample2
{
	internal class Runner
	{
		private readonly IInput _input;
		private readonly IOutput _output;
		private readonly ICalculator _calculator;

		public Runner(IInput input, ICalculator calculator, IOutput output)
		{
			_input = input;
			_output = output;
			_calculator = calculator;
		}

		public void Run()
		{

			_output.Write("Для вычисления суммы введите два числа, разделенных пробелом и нажмите Enter. Для завершения работы просто нажмите Enter");

			while(true)
			{
				var str = _input.Read();

				if (string.IsNullOrEmpty(str))
				{
					break;
				}

				var s = str.Split(' ');
				if (s.Length != 2)
				{
					_output.Write("Требуется ввести 2 числа, разделенных пробелом");
					continue;
				}

				if (!int.TryParse(s[0], out var x))
				{
					_output.Write($"{s[0]} не является числом");
					continue;
				}

				if (!int.TryParse(s[1], out var y))
				{
					_output.Write($"{s[1]} не является числом");
					continue;
				}

				var result = _calculator.Add(x, y);

				_output.Write($"{x} + {y} = {result}");
			}

			_output.Write("Работа завершена");
		}
	}
}
