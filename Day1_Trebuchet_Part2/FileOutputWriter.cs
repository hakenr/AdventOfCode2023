using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_Trebuchet_Part2
{
	public class FileOutputWriter : IOutputWriter
	{
		public void WriteOutput(int sum)
		{
			File.WriteAllText("D:\\TEMP\\output.txt", sum.ToString());
		}
	}
}
