using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using P = nilnul.num.real.expr_.Algebraic;

namespace nilnul.num.real.expr_.polynom.matrix_.sq.determ
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
		}

		static public P _Determ_0sq(P[,] sq) {


			var determ = nilnul.num.real.expr_.algebraic.matrix_.square._DeterminantX._Determinant_assumeSquare(
				sq
			);

			var d1 = nilnul.num.real.expr_.polynom.matrix_.sq._determ_.by_._ByCofactorX._Determinant_assumeSquare(
				sq
			);
			var d2 = nilnul.num.real.expr_.polynom.matrix_.sq._determ_.by_._BySubmatrixX._Determinant_0sq(
				sq
			);
			var d3 = nilnul.num.real.expr_.polynom.matrix_.sq._determ_.by_.sub_._ByParallelX._Determinant_0sq(
				sq
			);


			Assert.IsTrue(
				nilnul.num.real.expr_.polynom.str.be_._UnivalX.IsUnival(
					determ,d1,d2,d3
				)
			);

			return d3;

		}

	}
}
