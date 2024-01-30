namespace Day1_Trebuchet_Part2.Tests
{
	[TestClass]
	public class Day1ComputeTests
	{
		[TestMethod]
		public void TwoNumbers()
		{
			// arrange
			string input = "12";
			int expected = 12;

			// act
			int result = Program.Compute(input);

			// assert
			Assert.AreEqual(expected, result);
		}

		[TestMethod]
		public void WordAndNumber()
		{
			// arrange
			string input = "one4";
			int expected = 14;

			// act
			int result = Program.Compute(input);

			// assert
			Assert.AreEqual(expected, result);
		}

		[TestMethod]
		public void OverlappingWords()
		{
			// arrange
			string input = "twone4";
			int expected = 24;

			// act
			int result = Program.Compute(input);

			// assert
			Assert.AreEqual(expected, result);
		}

		[TestMethod]
		public void TwoLines()
		{
			// arrange
			string input = """
				123
				789
				""";
			int expected = 92;

			// act
			int result = Program.Compute(input);

			// assert
			Assert.AreEqual(expected, result);
		}

		[TestMethod]
		[ExpectedException(typeof(FormatException))]
		public void NoNumbers()
		{
			// arrange
			string input = "dsadas";

			// act
			int _ = Program.Compute(input);

			// assert
			// expected exception
		}
	}
}