using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace nilnul.num.real._matrix_._TEST_.nilnul0.num.integer.matrix.co_.sociable.multi
{
	[TestClass]
	public class UnitTest11
	{
		[TestMethod]
		public void TestMethod1()
		{
			var abs = nilnul._stat._RndX.RANDOM.NextDouble()*100;


			var x = new double[,] {
				{1,		1 }
				,
				{-1,	1}
			};
			 nilnul.num.real.matrix.op_.unary_._ScaleX.Scale(
				x
				,
				Math.Sqrt(
					abs/2
				)
			);

			var sqed = nilnul.num.real.matrix.co_.multible._MultiX._Multiply_assumeSociable(x,x);	 //			/2 * abs


			Assert.IsTrue(
				nilnul.num.real.matrix.re_.Approx4dbl.Singleton._re_assumeSameSize(
					sqed , new[,] {
						{ 0,abs}
						,
						{ -abs,0}
					} 
				)
			);
		}
	}
}
