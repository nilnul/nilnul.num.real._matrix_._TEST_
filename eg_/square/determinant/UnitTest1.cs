using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;

namespace nilnul.num.real.matrix._test.eg_.square.determinant
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var matrix = new double[,] { { -0.8, 1 }, { -0.5, 1.4 } };

			var d = nilnul.num.real.matrix_.square.to_.scalar_._DeterminantX._Determinant_assumeSquare(
				matrix
			);
			nilnul.num.real.be_.AboutNil4Dbl.SetInjected(.01); 

			Debug.Assert(
				nilnul.num.real.re_.approx_.ByInjected.Singleton.re(d,

				 -0.62
				 )
			);
		}
	}
}
