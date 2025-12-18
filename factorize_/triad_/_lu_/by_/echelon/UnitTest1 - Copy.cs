using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace nilnul.num.real.matrix.factorize_.triad_._lu_.by_.echelon
{
	[TestClass]
	public class UnitTest11
	{
		[TestMethod]
		public void TestMethod1()
		{




			var m =
				new Q[,] {
				{ 0,5,new Q(22,3) }
				,
				{4,2,1 }
				,
				{ 2,7,9 }
			}
				
			//	new Q[,] {
			//	{ 4,2,1}
			//	,
			//	{0,6, new Q(85,10) }
			//	,
			//	{ 0,5,new Q(22,3) }
			//}
				;  /// note all 1s along diagonal;

		

			var decomed = nilnul.num.real.matrix.factorize_.triad_._lu_.by_._ByEchelonX.Factorize(
	in m
	
);

			Assert.IsTrue(
				nilnul.num.real.matrix.be_.equilat_._ShufflerX.Be(in decomed.permute)	
			);

			Assert.IsTrue(
				nilnul.num.real.matrix.be_.equilat_._LowerX.Be(in decomed.lower)	
			);

			Assert.IsTrue(
				nilnul.num.real.matrix.be_.dent_._EchelonX.Be(in decomed.indent)	
			);

			

			Assert.IsTrue(
				nilnul.num.real.matrix.Eq8quotient.Singleton.Equals(
					m
					,
					nilnul.num.real.matrix.bi_.mul._GregatorX.Gregate(
						decomed.permute,decomed.lower, decomed.indent
					)
				)
			);




			//Assert.IsTrue(
			//	nilnul.num.real.matrix.Eq8quotient.Singleton.Equals(
			//		nilnul.num.quotient.matrix.of_._OfIntegersX.OfIntegers(
			//		decomed.permute
			//		)
			//		,
			//		new Q[,] {
			//			{ 0,1,0}
			//			,{0,0,1}
			//			,
			//			{1,0,0 }
			//		}.Transpose()
			//	)
			//);

			//Assert.IsTrue(
			//	nilnul.num.real.matrix.Eq8quotient.Singleton.Equals(
			//		(
			//		decomed.lower
			//		)
			//		,
			//		new Q[,] {
			//			{ 1,0,0}
			//			,{nilnul.num.quotient_._InvertX.HALF,1,0}
			//			,
			//			{0,new Q(5,6),1 }
			//		}
			//	)
			//);


			//Assert.IsTrue(
			//	nilnul.num.real.matrix.Eq8quotient.Singleton.Equals(
			//		(
			//		decomed.indent
			//		)
			//		,
			//		new Q[,] {
			//			{ 4,2,1}
			//			,{0, 6, new Q(85,10)}
			//			,
			//			{0,0,new Q(25,10) }
			//		}
			//	)
			//);




		}
	}
}
