using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace nilnul.num.real.matrix_.sq_.companion.minus.odd
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{

			var polynomial = (Q4[]) [2,3,5,7,10]; /// 2+3x+5x^2+7x^3+ x^4

			var companion = nilnul.num.real.matrix_.sq_.companion_.colly_.coefs8right.of_._OfStdCoefsX.CompanionMatrix_0coefsBeforeHighest(polynomial);

			Assert.IsTrue(
				nilnul.num.real.matrix.Eq8quotient.Singleton.Equals(
					companion
					,
					new Q4[,] {
						{ 0,0,0,0,-2 }
						,
						{1,0,0,0,-3 }
						,
						{0,1,0,0,-5 }
						,
						{0,0,1,0,-7 }
						,
						{0,0,0,1,-10 }

					}
				)
			);



			var companionLeft = nilnul.num.real.matrix_.sq_.companion_.colly_.coefs8left.of_._OfStdCoefsX._OfStdCoefs(polynomial);

			Assert.IsTrue(
				nilnul.num.real.matrix.Eq8quotient.Singleton.Equals(
					companionLeft
					,
					new Q4[,] {
						{ -10,1,0,0,0 }
						,
						{ -7,0,1,0,0 }
						,
						{-5,0,0,1,0 }
						,
						{-3,0,0,0,1 }
						,
						{-2,0,0,0 ,0}

					}
				)
			);

			var inverse = num.real.matrix_.sq_.companion_.colly_.invertible.op_._InvertX._Invert_0coefs(
				polynomial	
			);

			
			nilnul.num.real.matrix_.sq_.isosize.re_.reciprocal._VowX._Vow_0sq_1equisize(
					inverse
					,
				companion
				)
			;

			var a0=polynomial[0];
			var inverseByColly = nilnul.num.real.matrix_.sq_.companion_.colly_.coefs8left.of_._OfStdCoefsX._OfStdCoefs(
				polynomial.Skip(1).Append(1)    /// append the implicit leading coefficient 1
				.Select(
					x=>x /a0
				).Reverse().ToArray()
			);

			nilnul.num.real.matrix.eq._VowX.Vow(
				inverse
				,
				inverseByColly
			)
			;

			expr_.Var1 x = new("x");
			var m=nilnul.num.real.expr_.polynom.matrix.bi_._SubtractX._Minus_1equisize(
				companion
				,
				num.real.expr_.polynom.matrix_.sq_._ScalerX.Generate(
					companion.GetLength(0)
					,
					x	
				)
			);

			var d = nilnul.num.real.expr_.polynom.matrix_.sq._DeterminantX._Determinant_0sq(m);

			expr_.Algebraic y = new num.real.expr_.polynom_._univar.Coefs(
					polynomial.Append(1).Select(q => new nilnul.num.real_.Quotient(
						new nilnul.num.Quotient(q._numerator, q._denominator))
				)
				).exec(
					x
				);
			y.simplify();

			Assert.IsTrue(
				num.real.expr_.algebraic.Eq.Singleton.Equals(
					-d
					,
				y
				)
			);

		}
	}
}
