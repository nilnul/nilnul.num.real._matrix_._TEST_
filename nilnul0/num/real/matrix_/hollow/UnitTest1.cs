using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace nilnul.num.real.matrix_.hollow
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			const int cols = 3;
			var noRows = new int[0, cols];
			Assert.IsTrue(
				noRows.GetLength(1) ==cols
			);

			const int rows = cols;/// 10;
			var noCols = new int[rows,0];
			Assert.IsTrue(
				noCols.GetLength(0) ==rows
			);

			var multiplied = nilnul.num.real.matrix.bi_._MultiX._Multiply_1sociable(noCols, noRows);

			Assert.IsTrue(
				multiplied.GetLength(0) == rows
				&& multiplied.GetLength(1) == cols
			);

			Assert.IsTrue(
				nilnul.num.real.matrix.be_._OmniNilX.Be(multiplied)
			);

			var multiplied1trivia = nilnul.num.real.matrix.bi_._MultiX._Multiply_1sociable( noRows, noCols);

			Assert.IsTrue(
				multiplied1trivia.GetLength(0) == 0
				&& multiplied1trivia.GetLength(1) == 0
			);

			Assert.IsTrue(
				nilnul.num.real.matrix.be_._OmniNilX.Be(multiplied1trivia)
			);


		}
	}
}
