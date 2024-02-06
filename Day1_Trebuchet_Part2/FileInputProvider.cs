using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_Trebuchet_Part2
{
	public class FileInputProvider : IInputProvider
	{
		public string ProvideInput()
		{
			return File.ReadAllText("D:\\TEMP\\input.txt");
		}
	}
}
