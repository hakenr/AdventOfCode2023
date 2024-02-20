using Day1_Trebuchet_Part2;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

public class Program
{
	private static void Main(string[] args)
	{
		var builder = Host.CreateApplicationBuilder();

		builder.Services.AddTransient<IInputProvider, ConsoleInputOutputService>();
		builder.Services.AddTransient<IOutputWriter, ConsoleInputOutputService>();
		builder.Services.AddTransient<ILogger, ConsoleLogger>();
		builder.Services.AddTransient<Solver>();	

		// Transient = pokaždé nová instance
		// Scoped = jedna instance na request
		// Singleton = jedna instance na celou aplikaci

		var app = builder.Build();

		var solver = app.Services.GetRequiredService<Solver>();	
		solver.Execute();


		Console.ReadLine();
	}
}