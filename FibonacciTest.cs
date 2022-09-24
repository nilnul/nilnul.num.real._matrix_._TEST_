using Microsoft.VisualStudio.TestTools.UnitTesting;
using nilnul.num.natural.sequence;


namespace nilnul.num.real.matrix._test
{


	/// <summary>
	///This is a test class for FibonacciTest and is intended
	///to contain all FibonacciTest Unit Tests
	///</summary>
	[TestClass()]
	public class FibonacciTest
	{


		private TestContext testContextInstance;

		/// <summary>
		///Gets or sets the test context which provides
		///information about and functionality for the current test run.
		///</summary>
		public TestContext TestContext
		{
			get
			{
				return testContextInstance;
			}
			set
			{
				testContextInstance = value;
			}
		}

		#region Additional test attributes
		// 
		//You can use the following additional attributes as you write your tests:
		//
		//Use ClassInitialize to run code before running the first test in the class
		//[ClassInitialize()]
		//public static void MyClassInitialize(TestContext testContext)
		//{
		//}
		//
		//Use ClassCleanup to run code after all tests in a class have run
		//[ClassCleanup()]
		//public static void MyClassCleanup()
		//{
		//}
		//
		//Use TestInitialize to run code before running each test
		//[TestInitialize()]
		//public void MyTestInitialize()
		//{
		//}
		//
		//Use TestCleanup to run code after each test has run
		//[TestCleanup()]
		//public void MyTestCleanup()
		//{
		//}
		//
		#endregion


		/// <summary>
		///A test for Item_matrix
		///</summary>
		[TestMethod()]
		public void Item_matrixTest()
		{
			uint index = 7; // TODO: Initialize to an appropriate value
			uint expected = 13; // TODO: Initialize to an appropriate value
			uint actual;
			actual = Fibonacci.Item_matrix(index);
			Assert.AreEqual(expected, actual);


			uint index2 = 0; // TODO: Initialize to an appropriate value
			uint expected2 = 0; // TODO: Initialize to an appropriate value
			uint actual2;
			actual2 = Fibonacci.Item_matrix(index2);
			Assert.AreEqual(expected2, actual2);


			uint index3 = 1; // TODO: Initialize to an appropriate value
			uint expected3 = 1; // TODO: Initialize to an appropriate value
			uint actual3;
			actual3 = Fibonacci.Item_matrix(index3);
			Assert.AreEqual(expected3, actual3);





			Assert.Inconclusive("Verify the correctness of this test method.");
		}

		/// <summary>
		///A test for Item
		///</summary>
		[TestMethod()]
		public void ItemTest()
		{
			uint index = 0; // TODO: Initialize to an appropriate value
			ulong expected = 0; // TODO: Initialize to an appropriate value
			ulong actual;
			actual = Fibonacci.Item(index);
			Assert.AreEqual(expected, actual);


			uint index2 = 7; // TODO: Initialize to an appropriate value
			ulong expected2 = 13; // TODO: Initialize to an appropriate value
			ulong actual2;
			actual2 = Fibonacci.Item(index2);
			Assert.AreEqual(expected2, actual2);

			
			
			
			Assert.Inconclusive("Verify the correctness of this test method.");
		}
	}
}
