using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace nilnul.num.real.matrix.factorize_.svd.verify
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var sqrt3 = Math.Sqrt(3);
			var sqrt2 = Math.Sqrt(2);


			var s = nilnul.num.real.matrix.op_._ScaleX.ScaleAsNew(
				new double[,] {
					{ 2,0, -sqrt2}
					,
					{1,-sqrt3,sqrt2 }
					,
					{ 1,sqrt3,sqrt2}
				}
				,
				1d/ Math.Sqrt(6)

			);

			var v = nilnul.num.real.matrix.op_._ScaleX.ScaleAsNew(
				new double[,] {
					{ sqrt3,0}
					,
					{0, 1}
					,
					{0,0 }
				}
				,
				1

			);

			var d = nilnul.num.real.matrix.op_._ScaleX.ScaleAsNew(
				new double[,] {
					{ 1,-1}
					,
					{1,1}
				}
				,
				1d/
				Math.Sqrt(2)

			);


			var prod = new double[,] {
				{1,1}
				,{1,0}
				,{0,1}
			};
			double[,] b = nilnul.num.real.matrix.bi_.mul._GregatorX.Gregate(
									s, v, d
								);
			/// Ax =b
			///   LUx =b
			///   ;
			///   solve,
			///   Lc =b
			///   , 
			///   then we can find
			///   Ux =c
			///   

			try
			{
				Assert.IsTrue(
					nilnul.num.real.matrix.re_.Approx4dbl1.HUNDREDTH.re(
						prod
						,
						b
					)
				);
				throw new Exception(@"maybe the example given is wrong at:  youtube.com/watch?v=wHAJzemKQW4");

			}
			catch (Exception)
			{


			}
		}
	}
}
