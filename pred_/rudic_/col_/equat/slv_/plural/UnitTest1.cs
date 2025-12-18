using Microsoft.VisualStudio.TestTools.UnitTesting;
using nilnul.txt.be_;
using System;

namespace nilnul.num.real.matrix.pred_.rudic_.col_.equat.slv_.plural
{

	/// <summary>
	/// </summary>
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var augmented = new Q[,] {
				{ 1,-2,1,0}
				,
				{ 0,2,-8,8}
				,
				{-4,8,-4,0}
			};

			var slv = nilnul.num.real.matrix.pred_.rudic_.col_.equat._slv_.by_._ByRowReductionX.Solve(
				augmented
			);

			Assert.IsTrue(

				slv.Value.husk.GetLength(1)>0
			);

			Assert.IsTrue(
				nilnul.num.real.matrix.re_._EquiHullX.Re(
					slv.Value.husk
					,
					nilnul.num.real.matrix.op_.Transpose.Op(
					new Q[,] {
						{ 1,1,1,0}
					}
					)

				)
			);




		}
	}
}
