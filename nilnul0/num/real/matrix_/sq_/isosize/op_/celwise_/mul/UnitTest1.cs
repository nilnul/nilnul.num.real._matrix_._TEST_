using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace nilnul.num.real.matrix_.sq_.isosize.op_.celwise_.mul
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			void f(Q[,] m, Q b) {
				int w = m.GetLength(0);
				var other = nilnul.obj.matrix_._SquareX._Init_0width<Q>(
					w

				);

				for ( var i = 0; i < w; i++ )
				{
					for (int j = 0; j < w; j++)
					{
						other[i, j] = nilnul.num.quotient.op_._IndicX.DenomNonnil(b, i-j);
					}
				 }

				var merged = nilnul.num.real.matrix_.isosize.bi_.celwise_._MultiplyX._Multiply_1isosize(
					m, other	
				);

				Assert.IsTrue(
					num.real.matrix_.sq._DeterminantX._Determinant_0sq(m)
					==
					num.real.matrix_.sq._DeterminantX._Determinant_0sq(merged)

				);
			
			}

		}
	}
}
