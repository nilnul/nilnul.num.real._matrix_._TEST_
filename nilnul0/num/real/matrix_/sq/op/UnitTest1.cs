using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
using Assert = System.Diagnostics.Debug;

namespace nilnul.num.matrix._test.square.op
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void Inverse()
		{
			var i22 = nilnul.num.real.matrix_._SquareX.Init8dbl(2);

			var i22inverse = nilnul.num.real.matrix_.sq_.invertible.op_._InvertX._Inverse_0invertible(i22); //.square.solo.op.Inverse._Eval(i22);

			Debug.Assert(
				nilnul.num.real.matrix.rel.EqX.Eval(i22, i22inverse)	
			);

			var d00 = nilnul.num.real.matrix.square.X.Create();
			var d00inverse = real.matrix_.sq_.invertible.op_._InvertX._Inverse_0invertible(d00);//.square.solo.op.Inverse._Eval(d00);
			Debug.Assert(
				nilnul.num.real.matrix.square.be.NilNil.Eval(d00inverse)
					
			);



		}
		[TestMethod]

		public void Test_SvgFilterColorMatrixSaturateInverse() {
			var inverse = SvgFilterColorMatrixSaturateInverse();
			Debug.Write(
				nilnul.collection.matrix.to.Txt.Eval(
					inverse
				)
			);
		}

		public double[,] SvgFilterColorMatrixSaturateInverse() {
			var matrix = real.matrix.eg.SvgFilterColorMatrixSaturate.CreateMatrix(.5);

			var inverse = real.matrix_.sq_.invertible.op_._InvertX._Inverse_0invertible(matrix);
			return inverse;

		}

	}
}
