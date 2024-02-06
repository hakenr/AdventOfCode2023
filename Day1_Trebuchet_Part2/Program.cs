using Day1_Trebuchet_Part2;

public class Program
{
	private static void Main(string[] args)
	{
		var solver = new Solver(
			inputProvider: new ConsoleInputOutputService(),
			outputWriter: new ConsoleInputOutputService(),
			logger: new ConsoleLogger());

		solver.Execute();

		var solver2 = new Solver(
			inputProvider: new FileInputProvider(),
			outputWriter: new ConsoleInputOutputService(),
			logger: new NullLogger());

		solver2.Execute();

		Console.ReadLine();
	}
}