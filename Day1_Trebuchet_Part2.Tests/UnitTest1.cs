namespace Day1_Trebuchet_Part2.Tests
{
	[TestClass]
	public class UnitTest1
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
	}
}