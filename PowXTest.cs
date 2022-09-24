using nilnul.num.matrix;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace nilnul.num.real.matrix._test
{
    
    
    /// <summary>
    ///This is a test class for PowXTest and is intended
    ///to contain all PowXTest Unit Tests
    ///</summary>
	[TestClass()]
	public class PowXTest
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
		///A test for _Eval
		///</summary>
		[TestMethod()]
		[DeploymentItem("nilnul.num.matrix.exe")]
		public void _EvalTest()
		{
			uint[,] a = null; // TODO: Initialize to an appropriate value
			uint p = 0; // TODO: Initialize to an appropriate value
			uint[,] expected = null; // TODO: Initialize to an appropriate value
			uint[,] actual;
			actual = PowX.Eval(a, p);
			Assert.IsTrue(nilnul.num.matrix.Matrix_Extension.Eq( expected, actual));


			uint[,] a2 = null; // TODO: Initialize to an appropriate value
			uint p2 = 1; // TODO: Initialize to an appropriate value
			uint[,] expected2 = null; // TODO: Initialize to an appropriate value
			uint[,] actual2;
			actual2 = PowX.Eval(a2, p2);
			Assert.IsTrue(nilnul.num.matrix.Matrix_Extension.Eq(expected2, actual2));


			uint[,] a3 = null; // TODO: Initialize to an appropriate value
			uint p3 = 3; // TODO: Initialize to an appropriate value
			uint[,] expected3 = null; // TODO: Initialize to an appropriate value
			uint[,] actual3;
			actual3 = PowX.Eval(a3, p3);
			Assert.IsTrue(nilnul.num.matrix.Matrix_Extension.Eq(expected3, actual3));

			uint[,] a4 = new uint[0,0]; // TODO: Initialize to an appropriate value
			uint p4 = 1; // TODO: Initialize to an appropriate value
			uint[,] expected4 = new uint[0,0]; // TODO: Initialize to an appropriate value
			uint[,] actual4;
			actual4 = PowX.Eval(a4, p4);
			Assert.IsTrue(nilnul.num.matrix.Matrix_Extension.Eq(expected4, actual4));



			uint[,] a5 = new uint[,]{{0,1},{1,1}}; // TODO: Initialize to an appropriate value
			uint p5 = 6; // TODO: Initialize to an appropriate value
			uint[,] expected5 = new uint[,]{{5,8},{8,13}}; // TODO: Initialize to an appropriate value
			uint[,] actual5;
			actual5 = PowX.Eval(a5, p5);
			Assert.IsTrue(nilnul.num.matrix.Matrix_Extension.Eq(expected5, actual5));


			Assert.Inconclusive("Verify the correctness of this test method.");
		}
	}
}
