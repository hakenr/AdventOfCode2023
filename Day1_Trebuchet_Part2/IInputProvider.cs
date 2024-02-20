using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_Trebuchet_Part2
{
	public interface IInputProvider
	{
		string ProvideInput();

		string DoSomething(int number)
		{
			return null;
		}
	}
}
