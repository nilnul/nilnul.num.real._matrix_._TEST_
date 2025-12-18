using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace nilnul.num.quotient.matrix_.sq.op_._invert_.by_.gauss
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var a = new Q4[,] {
				{1,2 }
				,
				{2,4 }
			};

			try
			{
				var b = nilnul.num.quotient.matrix_.sq.op_._invert_.by_._ByLeftVentilatorX._Invert_0sq(a);

				throw new UnexpectedReachException($"{nameof(DivideByZeroException)} shall be thrown");

			}
			catch (DivideByZeroException ex) { }



		}
	}
}
