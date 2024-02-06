namespace Day1_Trebuchet_Part2.Tests
{
	[TestClass]
	public class Day1ComputeTests
	{
		[TestMethod]
		public void TwoNumbers()
		{
			// arrange
			var inputProviderStub = new TestInputProvider(input: "12");
			var outputWriterMock = new TestOutputWriter();
			var sut = new Solver(inputProviderStub, outputWriterMock, new NullLogger());

			// act
			sut.Execute();

			// assert
			Assert.AreEqual(12, outputWriterMock.Output);
		}

		[TestMethod]
		public void WordAndNumber()
		{
			// arrange
			var inputProviderStub = new TestInputProvider(input: "one4");
			var outputWriterMock = new TestOutputWriter();
			var sut = new Solver(inputProviderStub, outputWriterMock, new NullLogger());

			// act
			sut.Execute();

			// assert
			Assert.AreEqual(14, outputWriterMock.Output);
		}

		[TestMethod]
		public void OverlappingWords()
		{
			// arrange
			var inputProviderStub = new TestInputProvider(input: "twone4");
			var outputWriterMock = new TestOutputWriter();
			var sut = new Solver(inputProviderStub, outputWriterMock, new NullLogger());

			// act
			sut.Execute();

			// assert
			Assert.AreEqual(24, outputWriterMock.Output);
		}

		[TestMethod]
		public void TwoLines()
		{
			// arrange
			string input = """
				123
				789
				""";
			var inputProviderStub = new TestInputProvider(input);
			var outputWriterMock = new TestOutputWriter();
			var sut = new Solver(inputProviderStub, outputWriterMock, new NullLogger());

			// act
			sut.Execute();

			// assert
			Assert.AreEqual(92, outputWriterMock.Output);
		}

		[TestMethod]
		[ExpectedException(typeof(FormatException))]
		public void NoNumbers()
		{
			// arrange
			string input = "dsadas";
			var inputProviderStub = new TestInputProvider(input);
			var outputWriterMock = new TestOutputWriter();
			var sut = new Solver(inputProviderStub, outputWriterMock, new NullLogger());

			// act
			sut.Execute();

			// assert
			// expected exception
		}


		private class TestInputProvider : IInputProvider
		{
			private readonly string _input;

			public TestInputProvider(string input)
			{
				_input = input;
			}

			public string ProvideInput()
			{
				return _input;
			}
		}

		private class TestOutputWriter : IOutputWriter
		{
			public int Output { get; private set; }

			public void WriteOutput(int sum)
			{
				Output = sum;
			}
		}
	}
}