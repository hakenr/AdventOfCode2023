using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace Day1_Trebuchet_Part2
{
	public static class MyApplicationContext
	{
		public static ILogger Logger { get; set; } = new ConsoleLogger();
	}
}
