using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace nilnul.num.real.mat_.sq_.ii.factorize_.svd
{

	[TestClass]
	public class UnitTest11
	{
		[TestMethod]
		public void TestMethod1()
		{

			var m = new double[,] {
				{1.8,1.2 }
				,{ 4.4,4.6}
			};

			var sqrt2 = Math.Sqrt(2);
			var sqrt5 = Math.Sqrt(5);

			var sqrt10 = sqrt2*sqrt5;

			var sqrt10inv = 1d/sqrt10;

			var s = new double[,] {
				{ .7071, .7071}
				,
				{ -.7071,.7071}
			};






			var v = nilnul.num.real.matrix_._DiagonalX.Diagonal(
				2, 2, new double[] { 6.71, 0.44 });

			var sqrt2inv = 1d/ sqrt2;

			var d = new double[,] {

				{ .316, -.949}
				,
				{ .949,.316}
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
