using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace nilnul.num.real.matrix.kernel
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			{
				var m = new Q[,] {
				{ 1,1 }
				,
				{ 4, 1 }
			};

				var eigenVal = (Q)(-1);

				var shifted = num.real.matrix_.sq.bi_._SubtractX._Minus_0equilat_1scaler(
					m, eigenVal
				);

				var k = nilnul.num.real.matrix.op_._kernel_.by_._ByRowReductionX.Kernel(shifted);
				Assert.IsTrue(
					nilnul.num.real.matrix.cols.re_._equihull_.by_._ByTransposeX.Re(
						k
						,
						new Q[,] { { 1 }, { -2 } }
					)
				);


			}
			{
				var m = new Q[,] {
				{ -2,1 }
				,
				{ 4, -2 }
			};

				var k = nilnul.num.real.matrix.op_._kernel_.by_._ByRowReductionX.Kernel(m);
				Assert.IsTrue(
					nilnul.num.real.matrix.cols.re_._equihull_.by_._ByTransposeX.Re(
						k
						,
						new Q[,] { { 1 }, { 2 } }
					)
				);


			}

		}
	}
}
