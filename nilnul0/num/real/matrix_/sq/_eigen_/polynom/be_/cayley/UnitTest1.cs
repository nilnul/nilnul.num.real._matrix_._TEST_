using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace nilnul.num.real.matrix_.sq._eigen_.polynom.be_.cayley
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{

			var m = new Q[,] {
				{1,2 }
				,
				{3,4 }
			};

			var eigenExpr = new real.matrix_.sq.expr_.polynom_.univar_.Std(
				-2,-5	
			);

			var r=eigenExpr.apply(m);

			var r1= nilnul.num.real.matrix_.sq.expr_.polynom_.univar_.std._eval_.by_._PowX.Eval(eigenExpr.coefs, m);

			Assert.IsTrue(
				nilnul.num.real.matrix.be_._OmniNilX.Be(
				r
				)
			);
		}
	}
}
