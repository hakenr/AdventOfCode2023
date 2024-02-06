using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_Trebuchet_Part2
{
	public class ConsoleInputOutputService : IInputProvider, IOutputWriter
	{
		public string ProvideInput()
		{
			return Console.ReadLine();
		}

		public void WriteOutput(int sum)
		{
			Console.WriteLine(sum);
		}
	}
}
