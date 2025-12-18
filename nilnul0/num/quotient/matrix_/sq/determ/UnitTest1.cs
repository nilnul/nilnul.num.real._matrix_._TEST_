using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace nilnul.num.quotient.matrix_.sq.determ
{
	[TestClass]
	public class UnitTest1
	{


		[TestMethod]
		public void TestMethod1()
		{
			v(
				new Q4[,] { }
				,
				1
			);
			v(
				new Q4[,] { { 0 } }
				,0
			);
			v(
				new Q4[,] { { 1 } }
				,1
			);
			v(
				new Q4[,] { { 2 } }
				,2
			);
			v(
				new Q4[,] { { -2 } }
				,-2
			);

			v(
				new Q4[,] {
					{ 0,0 }
					,{0,0 }
				}
				,
				0
			);

			v(
				new Q4[,] {
					{ 0,1 }
					,{0,0 }
				}
				,
				0
			);

			v(
				new Q4[,] {
					{ 1,1 }
					,{0,0 }
				}
				,
				0
			);
			v(
				new Q4[,] {
					{ 1,1 }
					,{0,1 }
				}
				,
				1
			);

			v(
				new Q4[,] {
					{ 1,1 }
					,{0,3 }
				}
				,
				3
			);
			v(
				new Q4[,] {
					{ 1,1 }
					,{4,3 }
				}
				,
				-1
			);

			v(
				new Q4[,] {
					{ 2,3,5 }
					,{7,11,13 }
					,{8,14,15 }
				}
				,
				13
			);

			v(
				new Q4[,] {
					{ 2,3,5 }
					,{7,11,13 }
					,{new (3,8),new (5,14),15 }
				}
				,
				new quotient_.DenomNonnil(171,14)
			);

			v(
				new Q4[,] {
					{ 2,3,5 }
					,{0,11,13 }
					,{0,0,15 }
				}
				,
				new quotient_.DenomNonnil(330)
			);

			v(
				new Q4[,] {
					{ 2,3,5 }
					,
					{0,0,15 }
					,
					{0,11,13 }
					,
				}
				,
				new quotient_.DenomNonnil(-330)
			);

			v(
				new Q4[,] {
					{0,11,13 }
					,
					{ 2,3,5 }
					,
					{0,0,15 }
					,
				}
				,
				new quotient_.DenomNonnil(-330)
			);

			v(
				new Q4[,] {
					{0,11,13 }
					,
					{0,0,15 }
					,
					{ 2,3,5 }
					,
				}
				,
				new quotient_.DenomNonnil(330)
			);



		}

		void v(
			Q4[,] m
			,
			Q4 expected
		) {
			Assert.IsTrue(
				num.quotient.matrix_.sq._DeterminantX._Determinant_0sq(m) == expected	
			);
		
		}

		static public Q4 T(Q4[,] m) {
			var d00 = nilnul.num.quotient.matrix_.sq._DeterminantX._Determinant_0sq(m);

			var d1 = nilnul.num.quotient.matrix_.sq._determ_.by_._ByMutateX._Determinant_0sq(m);
			var d0 = nilnul.num.quotient.matrix_.sq._determ_.by_._ByScaleX._Determinant_0sq(m);


			var d2 = nilnul.num.real.matrix_.sq._determ_.by_._ByPermuteX._Determ_0sq(m);
			var d3 = nilnul.num.real.matrix_.sq._determ_.by_._ByRegenerateX._Determinant_0equilat(m);
			var d4 = nilnul.num.real.matrix_.sq._determ_.by_._BySubmatrixX._Determinant_0sq(m);





			var nival = nilnul.obj.str.be_._UnivalX.IsUnival_pars0(d00, d0, d1, d2, d3, d4);
			Assert.IsTrue(



				nival
			);


			Assert.IsTrue(



				nival
			);


			return d00;
		}
	}
}
