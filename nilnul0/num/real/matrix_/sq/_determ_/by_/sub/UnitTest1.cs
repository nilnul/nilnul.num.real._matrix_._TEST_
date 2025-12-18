using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace nilnul.num.real.matrix_.sq._determ_.by_.sub
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			v(
				new Q[,] { }
				,
				1
			);
			v(
				new Q[,] { { 0 } }
				,0
			);
			v(
				new Q[,] { { 1 } }
				,1
			);
			v(
				new Q[,] { { 2 } }
				,2
			);
			v(
				new Q[,] { { -2 } }
				,-2
			);

			v(
				new Q[,] {
					{ 0,0 }
					,{0,0 }
				}
				,
				0
			);

			v(
				new Q[,] {
					{ 0,1 }
					,{0,0 }
				}
				,
				0
			);

			v(
				new Q[,] {
					{ 1,1 }
					,{0,0 }
				}
				,
				0
			);
			v(
				new Q[,] {
					{ 1,1 }
					,{0,1 }
				}
				,
				1
			);

			v(
				new Q[,] {
					{ 1,1 }
					,{0,3 }
				}
				,
				3
			);
			v(
				new Q[,] {
					{ 1,1 }
					,{4,3 }
				}
				,
				-1
			);

			v(
				new Q[,] {
					{ 2,3,5 }
					,{7,11,13 }
					,{8,14,15 }
				}
				,
				13
			);

			v(
				new Q[,] {
					{ 2,3,5 }
					,{7,11,13 }
					,{new (3,8),new (5,14),15 }
				}
				,
				new quotient_.DenomNonnil(171,14)
			);


		}

		void v(
			Q[,] m
			,
			Q expected
		) {
			Assert.IsTrue(
				num.real.matrix_.sq._determ_.by_._BySubmatrixX._Determinant_0sq(m) == expected	
			);
		
		}
	}
}
