using System.Text.RegularExpressions;
using Microsoft.Extensions.Logging;

namespace Day1_Trebuchet_Part2;

public class Solver
{
	private readonly IInputProvider _inputProvider;
	private readonly IOutputWriter _outputWriter;
	private readonly ILogger _logger;

	public Solver(
		IInputProvider inputProvider,
		IOutputWriter outputWriter,
		ILogger logger)
	{
		_inputProvider = inputProvider;
		_outputWriter = outputWriter;
		_logger = logger;
	}

	public void Execute()
	{
		string input = _inputProvider.ProvideInput();

		var sum = 0;
		foreach (var line in input.Split(Environment.NewLine))
		{
			var firstNumber = Regex.Replace(line, @".*?(\d|one|two|three|four|five|six|seven|eight|nine).*", "$1");
			var lastNumber = Regex.Replace(line, @".*(\d|one|two|three|four|five|six|seven|eight|nine).*", "$1");

			int GetNumber(string number) => number switch
			{
				"one" => 1,
				"two" => 2,
				"three" => 3,
				"four" => 4,
				"five" => 5,
				"six" => 6,
				"seven" => 7,
				"eight" => 8,
				"nine" => 9,
				_ => int.Parse(number)
			};

			_logger.LogInformation($"{line} => {firstNumber}, {lastNumber} => {GetNumber(firstNumber)}, {GetNumber(lastNumber)}");
			sum += GetNumber(firstNumber) * 10 + GetNumber(lastNumber);
		}

		_outputWriter.WriteOutput(sum);
	}
}
