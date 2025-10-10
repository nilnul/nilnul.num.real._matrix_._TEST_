using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace nilnul.num.real.matrix.to_.factorize_.svd
{

	[TestClass]
	public class UnitTest11
	{
		[TestMethod]
		public void TestMethod1()
		{

			var m = new double[,] {
				{8,5,7,3,9 }
				,{ 1,4,-6,1,1}
				,
				{ 0,4,-3,-3,6}
			};


			var s = new double[,] {
				{ -.96, .22, -.15}
				,
				{ -.04,-.69, -.73}
				,
				{ -.26, -.69,.67}
			};




			var v = nilnul.num.real.matrix_._DiagonalX.Diagonal(3,5, new double[] { 
				15.48,9.64,4.51 
			});

			var d = new double[,] {

				{ -.5,-.39,-.37,-.14,-.66}
				,
				{ .11,-.46,.8,.21,-.3 }
				,
				{ -.43,-.21,.29,-.71, .44}
				,
				{ -.75, .3,.19,.54,.17}
				,
				{ .02,-.71,-.32,.38,.5}
			};

			var prod = nilnul.num.real.matrix.str_.started_.productable._ProductX._Product_0productable(
				s,v,d
			);

			Assert.IsTrue(
				nilnul.num.real.matrix.re_.Approx4dbl1.HUNDREDTH.re(
					prod,
					m
				)
			);

		}
	}
}
