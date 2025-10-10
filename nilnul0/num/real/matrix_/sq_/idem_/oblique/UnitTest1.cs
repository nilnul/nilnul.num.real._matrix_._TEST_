using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace nilnul.num.real.matrix_.sq_.idem_.oblique
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var a = new Q(3);
			var m = new Q[,] {
				{0,0 }
				,
				{a,1 }
			};

			var mSq = nilnul.num.real.matrix_.sq.op_._SquareX._Square_0regular(m);

			Assert.IsTrue(
				nilnul.num.real.matrix.Eq8quotient.Singleton.Equals(
					m,mSq
				)	
			);
		}
	}
}
