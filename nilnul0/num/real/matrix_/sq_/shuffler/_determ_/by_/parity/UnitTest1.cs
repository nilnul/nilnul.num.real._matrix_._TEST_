using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace nilnul.num.real.matrix_.sq_.shuffler._determ_.by_.parity
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			///<see cref="nilnul.ling.book_.HuanZhendong"/>
			///p10
			///sect2.2/q:
			///4.1
			///
			var m = new Q[,] {
				{ 0,0,1,0}
				,
				{0,1,0,0 }
				,
				{0,0,0,1 }
				,{1,0,0,0}
			};

			var d = nilnul.num.real.matrix_.sq_.shuffler._determ_.by_._ByParityX._Determ_0shuffler(m);

			Assert.AreEqual( d, 1);

			var d1 = nilnul.num.real.matrix_.sq._DeterminantX._Determinant_0sq(m);
			Assert.IsTrue( d1 == d);
		}
	}
}
