using Microsoft.VisualStudio.TestTools.UnitTesting;
using nilnul.txt.be_;
using System;

namespace nilnul.num.real.matrix.pred_.rudic_.col_.equat.slv_.ppt25f_.chp1_.sect1_
{

	/// <summary>
	/// 这是 
	///		黄振东、陆建华 写的《线性代数》教材 
	///		PPT
	///		1-1
	///		slide3
	/// </summary>
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var augmented = new Q[,] {
				{ 2,-1,-1,1,2}
				,
				{ 1,1,-2,1,4}
				,
				{4,-6,2,-2,4 }
				,
				{ 3,6,-9,7,9}
			};
			var slv = nilnul.num.real.matrix.pred_.rudic_.col_.equat._slv_.by_._ByRowReductionX.Solve(
				augmented
			);

			Assert.IsTrue(

				nilnul.num.real.str.Eq8quotient.Singleton.Equals(
					slv.Value.drift
					,
					[4,3,0,-3]
				)
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
