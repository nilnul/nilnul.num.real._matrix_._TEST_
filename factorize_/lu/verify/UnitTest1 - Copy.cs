using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace nilnul.num.real.matrix.factorize_.lu.verify
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var l = new Q[,] {
				{ 1,0,0}
				,
				{1,1,0 }
				,
				{ 0,-1,1}
			};  /// note all 1s along diagonal;

			var u = new Q[,] {
				{1,1 }
				,
				{0,-1 }
				,
				{0,0 }
			};

			var prod = new Q[,] {
				{1,1}
				,{1,0}
				,{0,1}
			};
			/// Ax =b
			///   LUx =b
			///   ;
			///   solve,
			///   Lc =b
			///   , 
			///   then we can find
			///   Ux =c
			///   
			Assert.IsTrue(
				nilnul.num.real.matrix.Eq8quotient.Singleton.Equals(
					prod
					,
					nilnul.num.real.matrix.bi_._MultiX.Multiply(
						l, u
					)
				)
			);
		}
	}
}
