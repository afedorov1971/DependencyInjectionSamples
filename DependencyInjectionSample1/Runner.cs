namespace DependencyInjectionSample1
{
	internal class Runner
	{
		public void Run()
		{

			var output = new Output();
			var calculator = new Calculator();
			var input = new Input();
			
			output.Write("Для вычисления суммы введите два числа, разделенных пробелом и нажмите Enter. Для завершения работы просто нажмите Enter");

			while(true)
			{
				var str = input.Read();

				if (string.IsNullOrEmpty(str))
				{
					break;
				}

				var s = str.Split(' ');
				if (s.Length != 2)
				{
					output.Write("Требуется ввести 2 числа, разделенных пробелом");
					continue;
				}

				if (!int.TryParse(s[0], out var x))
				{
					output.Write($"{s[0]} не является числом");
					continue;
				}

				if (!int.TryParse(s[1], out var y))
				{
					output.Write($"{s[1]} не является числом");
					continue;
				}

				var result = calculator.Add(x, y);

				output.Write($"{x} + {y} = {result}");
			}

			output.Write("Работа завершена");
		}
	}
}
