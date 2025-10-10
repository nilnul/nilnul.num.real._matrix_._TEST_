using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace nilnul.num.real._matrix_._TEST_.nilnul0.num.real.matrix_.sq_.bi_.fibonacci
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			double[,] matrix = {
				{ 0,1}
				,
				{1,1 }
			};

			var sqrt5 = Math.Sqrt(5); //nilnul.num.real_.eg_.sqrt_._OfTwoX;

			var eigenvals = new double[] {
				nilnul.num.real_.eg_._GoldenRatioX.GtOne
				,
				-nilnul.num.real_.eg_._GoldenRatioX.LtOne

			};

			var eigenBasis = new double[,] {
				{ nilnul.num.real_.eg_._GoldenRatioX.LtOne ,1}
				,
				{-nilnul.num.real_.eg_._GoldenRatioX.GtOne,1 }

			};

			var inverted = nilnul.num.real.matrix_.sq_.invertible.op_.unary_.Invert._Matrix_assumeSquare1invertible(eigenBasis);

			var similarized = nilnul.num.real.matrix.co_.divisible._DivideX._Divide_assumeDivisable(
nilnul.num.real.matrix.co_.multible._MultiX._Multiply_assumeSociable(
				eigenBasis
				,
				matrix
			)
,eigenBasis
);
			// shall be eigenvals


			/// and matrix^n = inverted *  similarized^n * eigenbasis.

		}
	}
}
