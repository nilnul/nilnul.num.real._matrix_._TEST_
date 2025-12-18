using Microsoft.VisualStudio.TestTools.UnitTesting;
using nilnul.txt.be_;
using System;

namespace nilnul.num.real.matrix.pred_.rudic_.col_.equat.slv_.empty
{

	/// <summary>
	/// </summary>
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var augmented = new Q[,] {
				{ 1,-2,1,0}
				,
				{ 0,2,-8,8}
				,
				{-4,8,-4,-9 }
			};
			var slv = nilnul.num.real.matrix.pred_.rudic_.col_.equat._slv_.by_._ByRowReductionX.Solve(
				augmented
			);

			Assert.IsNull(

				slv
			);

		



		}
	}
}
