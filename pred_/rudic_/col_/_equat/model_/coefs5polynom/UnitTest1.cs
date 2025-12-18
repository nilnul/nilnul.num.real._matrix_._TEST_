using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace nilnul.num.real.matrix.pred_.rudic_.col_._equat.model_.coefs5polynom
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			/// for a <see cref="nilnul.num.real.fn_.polynom_.IQuadratic"/>
			/// 
			/// f(1) = 0
			/// f(2) =3
			/// f(-3) =28
			/// 
			/// ax^2 + bx +c
			/// c+bx +a x^2
			/// 
			///, now let's get c,b,c
			var coef = new Q[,] {
				{
					1, 
				
				}
			};

			var coef1 = nilnul.num.real.matrix_.sq_._VandermondeX.Generate(
				1,2,-3	
			);

			var slv = nilnul.num.real.matrix.pred_.rudic_.col_.equat._slv_.by_._ByRowReductionX.Solve(
				coef1
				,
				[0,3,28]
			);

			Assert.IsTrue(
				nilnul.num.real.vec._Eq_assumeIsosize.Unison.Equals(
				slv.Value.drift, [1,-3,2]	
			));

			Assert.IsTrue(
				nilnul.num.real.matrix.Eq8quotient.Singleton.Equals(
				slv.Value.husk
				, nilnul.obj.matrix_.isohigh_._CollessX.OfHigh<Q>(
					slv.Value.drift.Length	
				)	
			));



			/// this works for even more higher degreed polynom
		}
	}
}
