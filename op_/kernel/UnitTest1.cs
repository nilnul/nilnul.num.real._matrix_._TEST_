using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace nilnul.num.real.matrix.op_.kernel
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var m = new Q[,] {
				{ 0	,1,0	,1,0}
				,
				{0	,0,1	,1 ,0}
				,{0	,0,0,0,0 }
			};

			var k = nilnul.num.real.matrix.op_._kernel_.by_._ByRowReductionX.Kernel(m);

			var kTrans = k.Transpose();


			Assert.IsTrue(
				nilnul.num.real.matrix.Eq8quotient.Singleton.Equals(
				
				 k
				 ,
				 new Q[,] {
					{ 
					  1,0,0,0,0
					 }
					 ,
					{ 0,-1,-1,1,0}
					 ,
					{ 0,0,0,0,1}
				 }.Transpose()
				 )
				 );
		}
	}
}
