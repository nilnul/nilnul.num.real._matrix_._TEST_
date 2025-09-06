using Microsoft.VisualStudio.TestTools.UnitTesting;
using nilnul.obj.matrix;
using System;
using System.Linq;

namespace nilnul.num.real.vecs_.indep.op_._schmidt_.by_.sq
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var m = new Q[,] {
				{3,1 }
				,
				{ 2,2}
			};

			var schmidt = nilnul.num.real.vecs_.indep.op_._schmidt_.by_._BySquareX._Ortho_0indep(m);


			var enumerable = schmidt.Rows().ToArray();
			Assert.IsTrue(
				nilnul.num.real.vec.re_._OrthicX.Re(
					enumerable[0]
					,
					enumerable[1]
				)
			);
		}
	}
}
