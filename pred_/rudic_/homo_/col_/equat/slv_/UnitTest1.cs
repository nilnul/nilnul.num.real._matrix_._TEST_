using Microsoft.VisualStudio.TestTools.UnitTesting;
using nilnul.txt.be_;
using System;

namespace nilnul.num.real.matrix.pred_.rudic_.col_.homo_.equat.slv_
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
				{ 1,1,0,0}
				,
				{ 0,1,0,-1}
			};

			var slv = nilnul.num.real.matrix.pred_.rudic_.homo_.col_.equat._slv_.by_._ByKernelX.Solve(
				augmented
			);

			var slvT = slv.Transpose();

			var other = new Q[,] {
				{0,1,1,0 }
				,
				{-1,2,2,1 }
			};

			var canonA = nilnul.num.real.matrix.op_.vent_._indep_.by_._GaussianX.ToIndepVent(
				slvT
			);
			var canonB = nilnul.num.real.matrix.op_.vent_._indep_.by_._GaussianX.ToIndepVent(
				other
			);


			var subsided = nilnul.obj.matrix_.isowide.bi_._SubmergeX._Submerge_1isowide(
				canonA,canonB
			);

			var r = nilnul.num.real.matrix.op_.dent_._EchelonX.EchelonForRank(ref subsided);


			/// find a common row
			/// 
			var intersected = nilnul.num.real.matrix_.isowide_.vent.bi_._IntersectX.Intersect(
				canonA,canonB
			);

			Assert.IsTrue(
				r< canonA.GetLength(0) + canonB.GetLength(1)
			);


		}
	}
}
