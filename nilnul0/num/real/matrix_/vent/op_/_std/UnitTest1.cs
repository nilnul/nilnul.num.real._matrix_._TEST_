using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace nilnul.num.real.matrix_.vent.op_.std
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var m = new Q[,] {
				{ 1,0,-1,0,4}
				,
				{ 0,1,-1,0,3 }
				,
				{ 0,0,0,1,-3 }
				,
				{ 0,0,0,0,0 }
			};

			///swap
			///

			var swapper = nilnul.num.real.matrix_.sq_.basic_._SwapX._Generate8quotient_0wide_1original_2other(5,2,3);

			Assert.IsTrue(
	nilnul.num.real.matrix.be_._CanonicalX.Be(
		nilnul.num.real.matrix.bi_._MultiX._Multiply_1sociable(
			swapper, swapper
		)
	)
);


			var swapped = nilnul.num.real.matrix.bi_._MultiX._Multiply_1sociable(
				m,swapper
			);


			///<see cref="real.matrix_.sq_.frobenius"/>
			var frobenius = nilnul.num.real.matrix_.sq_._CanonicalX.Generate8quotient(5);


			frobenius[ 0,3] =1;
			frobenius[ 1,3] =1;  /// this is <see cref="nilnul.num.real.matrix.op_.colwise_.IByMatrixFroRight"/>


			var invert = nilnul.num.real.matrix_.sq_.triag_.upper_.frobenius.op_._InvertX._Invert_1col(
				frobenius,3	
			);

			Assert.IsTrue(
				nilnul.num.real.matrix.be_._CanonicalX.Be(
					nilnul.num.real.matrix.bi_._MultiX._Multiply_1sociable(
						frobenius,invert	
					)
				)
			);

			var frobenius1 = nilnul.num.real.matrix_.sq_._CanonicalX.Generate8quotient(5);


			frobenius1[ 0,4] = -4;
			frobenius1[ 1,4] = -3;
			frobenius1[ 2,4] = 3;/// a second colwise op

			var invert1 = nilnul.num.real.matrix_.sq_.triag_.upper_.frobenius.op_._InvertX._Invert_1col(
				frobenius1,4	
			);

			Assert.IsTrue(
				nilnul.num.real.matrix.be_._CanonicalX.Be(
					nilnul.num.real.matrix.bi_._MultiX._Multiply_1sociable(
						frobenius1,invert1	
					)
				)
			);

			var frobeniusCompound = nilnul.num.real.matrix.bi_._MultiX._Multiply_1sociable(
				frobenius
				,
				frobenius1
			);	


			var invert4frobeniuses= nilnul.num.real.matrix_.sq_.invertible.op_._InvertX._Invert_0invertible(
				frobeniusCompound	
			);


			var invert4frobeniuses8grid = nilnul.num.real.matrix_.sq.grid_.triag_.skew.op_._InvertX._Invert_0gridSkew_1rows_2cols(
				frobeniusCompound,
				(0,3)
				,
				(3,5)
			);


			Assert.IsTrue(

				num.real.matrix.Eq8quotient.Singleton.Equals(
					invert4frobeniuses, invert4frobeniuses8grid
				)
			);




			Assert.IsTrue(
				nilnul.num.real.matrix.be_._CanonicalX.Be(
					nilnul.num.real.matrix.bi_._MultiX._Multiply_1sociable(
						frobeniusCompound, invert4frobeniuses	
					)
				)
			);



			var std = nilnul.num.real.matrix.bi_._MultiX._Multiply_1sociable(
				swapped
				,
				frobeniusCompound
			);


			Assert.IsTrue(
				nilnul.num.real.matrix.be_._StdX.IsStd(
					std
				)
			);

			var allColwiseOps = nilnul.num.real.matrix.str_.started_.productable._ProductX._Product_1productable(
				swapper
				,frobeniusCompound
			);

			Assert.IsTrue(
				nilnul.num.quotient.matrix_.sq.be_._InvertibleX._IsInvertible_0sq(
						allColwiseOps
					)
			);

			var invert4allColwiseOps = nilnul.num.real.matrix_.sq_.invertible.op_._InvertX._Invert_0invertible(
				allColwiseOps
			);

			Assert.IsTrue(
				nilnul.num.quotient.matrix_.sq.be_._InvertibleX._IsInvertible_0sq(
						invert4allColwiseOps
					)
			);

			var invert4allColwiseOps_bySwap =nilnul.num.real.matrix.bi_._MultiX._Multiply_1sociable(
				invert4frobeniuses
				,
				swapper  /// (AB) \ 1 = B\1 A\1
			);

			Assert.IsTrue(

				num.real.matrix.Eq8quotient.Singleton.Equals(
					invert4allColwiseOps, invert4allColwiseOps_bySwap
				)
			);



			var std1 = nilnul.num.real.matrix.bi_._MultiX._Multiply_1sociable(
				m
				,
				allColwiseOps
			);


			Assert.IsTrue(
				nilnul.num.real.matrix.be_._StdX.IsStd(
					std1
				)
			);

		}
	}
}
