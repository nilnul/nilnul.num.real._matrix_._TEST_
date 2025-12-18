using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace nilnul.num.real.matrix.factorize_.triad_._lu_.by_.echelon
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
				{2,1,0 }
				,
				{ -1,2,1}
			};  /// note all 1s along diagonal;

			var u = new Q[,] {
				{1,2,1,3 }
				,
				{0,2,1,6 }
				,
				{0,0,1,-1 }
			};

			var prod = new Q[,] {
				{1,2,1,3}
				,{2,6,3,12}
				,{-1,2,2,8
				}
			};

			var decomed = nilnul.num.real.matrix.factorize_.triad_._lu_.by_._ByEchelonX.Factorize(
	in prod
	
);

			Assert.IsTrue(
				nilnul.num.real.matrix.be_.equilat_._ShufflerX.Be(in decomed.permute)	
			);

			Assert.IsTrue(
				nilnul.num.real.matrix.be_.trape_._LowerX.IsLower(in decomed.lower)	
			);

			Assert.IsTrue(
				nilnul.num.real.matrix.be_._DentX.Be(in decomed.indent)	
			);

			

			Assert.IsTrue(
				nilnul.num.real.matrix.Eq8quotient.Singleton.Equals(
					prod
					,
					nilnul.num.real.matrix.bi_.mul._GregatorX.Gregate(
						decomed.permute,decomed.lower, decomed.indent
					)
				)
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
