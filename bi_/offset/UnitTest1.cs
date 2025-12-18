using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace nilnul.num.real.matrix.bi_.offset
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{

			Assert.IsTrue(
				nilnul.num.real.matrix.Eq8quotient.Singleton.Equals(
					nilnul.num.real.matrix.bi_._OffsetX.Offset(
						new Q[,] {
							{ 1,3,2}
							,{ 2,3,1}
						}
						,
						new Q[,] {
							{1,6 }
							,{ 0,1}
						}
					)
					,
					new Q[,] {
						{ 1,3,2,0,0}
						,
						{ 2,3,1,0,0}
						,
						{ 0,0,0,1,6}
						,{0,0,0,0,1}
					}
				)
			);
		}
	}
}
