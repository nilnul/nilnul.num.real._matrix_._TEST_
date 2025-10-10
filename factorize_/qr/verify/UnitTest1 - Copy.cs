using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace nilnul.num.real.matrix.factorize_.qr.verify
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var sqrt3 = Math.Sqrt(3);
			var l = nilnul.num.real.matrix.op_._ScaleX.ScaleAsNew( 
				new double[,] {
					{ sqrt3, 1}
					,
					{sqrt3,-1 }
					,
					{ 0,2}
				}
				,  
				1d/ Math.Sqrt(6)

			);  

			var u = nilnul.num.real.matrix.op_._ScaleX.ScaleAsNew( 
				new double[,] {
					{ 1,1d/2}
					,
					{0, Math.Sqrt(3)/2 }
				}
				,  
				Math.Sqrt(2)

			); 

			var prod = new double[,] {
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
				nilnul.num.real.matrix.re_.Approx4dbl1.KILOTH.re(
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
