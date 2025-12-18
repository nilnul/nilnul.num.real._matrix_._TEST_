using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace nilnul.num.quotient.matrix.factors_.co_.veritas9vent
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{

			/// todo: matrix division in inversion and <see cref="real.matrix.pred_.rudic_.col_.equat._slv_.by_._ByRowReductionX"/>
			var a = new Q4[,] {
				{1,2 }
				,
				{2,4 }
			};

			var b = nilnul.num.quotient.matrix.factorize_.co_._VertibleVentX.Factorize(a);

			var g = b.vertible;
			var v = b.vent;
			Assert.IsTrue(
				nilnul.num.real.matrix.be_._InvertibleX.Be( g)
			);
			Assert.IsTrue(
				nilnul.num.real.matrix.be_.dent_.paragon_._ReducedEchelonX.Be(in v)
			);


			Assert.IsTrue(
				nilnul.num.real.matrix.Eq8quotient.Singleton.Equals(
					nilnul.num.real.matrix.bi_._MultiX._Multiply_1sociable(
						g, v
					)
					,
					a
				)
			);


		}

		[TestMethod]
		public void TestMethod2()
		{

			var g1 = new Q4[,] {
				{ 2,3,5}
				,
				{ 7,11,13}
				,
				{ 9,17,31}
			
			};

			var v1 = new Q4[,] {
				{ 0,1,0,3,5}
				,
				{ 0,0,0,0,0}
				,
				{ 0,0,0,7,0}

			};

			/// todo: matrix division in inversion and <see cref="real.matrix.pred_.rudic_.col_.equat._slv_.by_._ByRowReductionX"/>
			var a = 					nilnul.num.real.matrix.bi_._MultiX._Multiply_1sociable(
						g1, v1
					)

				;



			var b = nilnul.num.quotient.matrix.factorize_.co_._VertibleVentX.Factorize(a);

			var g = b.vertible;
			var v = b.vent;

			Assert.IsTrue(
				nilnul.num.real.matrix.be_._InvertibleX.Be( g)
			);

			Assert.IsTrue(
				nilnul.num.real.matrix.be_.dent_.paragon_._ReducedEchelonX.Be(in v)
			);


			Assert.IsTrue(
				nilnul.num.real.matrix.Eq8quotient.Singleton.Equals(
					nilnul.num.real.matrix.bi_._MultiX._Multiply_1sociable(
						g, v
					)
					,
					a
				)
			);


		}



	}
}
