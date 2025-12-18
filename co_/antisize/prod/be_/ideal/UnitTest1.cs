using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace nilnul.num.real.matrix.co_.antisize.prod.be_.ideal
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			///Can two non-square (rectangular) matrices multiply to give the identity matrix?
			///Yes — but only one-sided identity is possible.
			///That is:If A is m×n and B is n×m,then AB=I [m*m]  can happen only if m≤n (In that case A has a right inverse, and B has a left inverse.)
			///

			var m = new Q[,] {
				{1,0,0 }
				,
				{0,1,0 }
			};

			var b = new Q[,] {
				{ 1,0}
				,{0,1 }
				,{0,0 }
			};

			Assert.IsTrue(
				nilnul.num.real.matrix.be_._CanonicalX.Be(
					num.real.matrix.bi_._MultiX._Multiply_1sociable(m,b)
				)	
			);

			/// <see cref="nilnul.num.real.matrix_.rowly_.orthonorm.op_.IEndomul"/>

		}
	}
}
