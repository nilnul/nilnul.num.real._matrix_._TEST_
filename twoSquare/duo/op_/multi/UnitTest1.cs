using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using N = nilnul._num.bigint.be.Natural.Asserted;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;
using R = nilnul.num.RealI;
using R2 = nilnul.num.Real;
using System.Diagnostics;

namespace nilnul.num.real.matrix._test.twoSquare.duo.op_.multi
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void Multi_nonCommutable()
		{
			var a = new nilnul.num.real.matrix_.square_.Secondary(1,2,3,4);
			var b = new nilnul.num.real.matrix_.square_.Secondary(5,6,7,8);

			var c = a * b;
			var d = b * a;

			Debug.WriteLine(c.ToString());
			Debug.WriteLine(d);




		}
	}
}
