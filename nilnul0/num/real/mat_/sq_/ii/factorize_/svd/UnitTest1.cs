using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace nilnul.num.real.mat_.sq_.ii.factorize_.svd
{

	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{

			var m = new double[,] {
				{3,0 }
				,{ 4,5}
			};

			var sqrt2 = Math.Sqrt(2);
			var sqrt5 = Math.Sqrt(5);

			var sqrt10 = sqrt2*sqrt5;

			var sqrt10inv = 1d/sqrt10;

			var s = new double[,] {
				{ sqrt10inv, -3*sqrt10inv}
				,
				{ 3*sqrt10inv, sqrt10inv}
			};






			var v = nilnul.num.real.matrix_._DiagonalX.Diagonal(
				2, 2, new double[] { 3*sqrt5, sqrt5 });

			var sqrt2inv = 1d/ sqrt2;

			var d = new double[,] {

				{ sqrt2inv, sqrt2inv }
				,
				{ -sqrt2inv,sqrt2inv }
			};

			var prod = nilnul.num.real.matrix.str_.started_.productable._ProductX._Product_0productable(
				s,v,d
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
