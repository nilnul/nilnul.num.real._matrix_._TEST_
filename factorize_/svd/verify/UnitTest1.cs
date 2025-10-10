using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace nilnul.num.real.matrix.to_.factorize_.svd
{

	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{

			var m = new double[,] {
				{3,2,2 }
				,{ 2,3,-2}
			};

			var sqrt2Inv = 1d/Math.Sqrt(2);

			var decomposed = new double[,] {
				{ sqrt2Inv, -sqrt2Inv}
				,
				{ sqrt2Inv, sqrt2Inv}
			};


			var sqrt18inv = 1d/Math.Sqrt(18);


			var v = nilnul.num.real.matrix_._DiagonalX.Diagonal(2, 3, new double[] { 5, 3 });


			var d = new double[,] {

				{ sqrt2Inv, sqrt2Inv, 0 }
				,
				{ -sqrt18inv, sqrt18inv, -4* sqrt18inv }
				,
				{ 2d/3d, -2d/3d, -1d/3d}
			};

			var prod = nilnul.num.real.matrix.str_.started_.productable._ProductX._Product_0productable(
				decomposed,v,d
			);

			Assert.IsTrue(
				nilnul.num.real.matrix.re_.Approx4dbl1.KILOTH.re(
					prod,
					m
				)
			);

		}
	}
}
