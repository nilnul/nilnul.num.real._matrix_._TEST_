using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace nilnul.num.real.matrix_.sq_.triag_.upper_.invertible.op_._invert_.by_.substitute.noLiteralInvert
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			for (int i = 0; i < 8; i++)
			{
				TestMethod1(i);

			}
			///var wide = nilnul._stat._RndX.RANDOM.Next(9);



		}
		public void TestMethod1(int wide)
		{

			var m = new Q[wide, wide];
			for (var i = 0; i < wide; i++)
			{
				var j = 0;
				for (; j < i; j++)
				{
					m[i, j] = 0;

				}
				m[i, j] =nilnul.num.quotient_.unnil.of_._RndX._OfRnd_0positive();
				j++;

				for (; j < wide; j++)
				{
					m[i, j] = nilnul.num.quotient.of_._RndX._OfRnd_0positive();
				}

			}

			var inverted = nilnul.num.real.matrix_.sq_.triag_.upper_.invertible.op_._invert_.by_._BackwardSubstitutionX._Invert_0upperInvertible(
				m
			);

			//var inverted8literal = nilnul.num.real.matrix_.sq_.invertible.op_._InvertX._Inverse_0invertible(m);

			//Assert.IsTrue(
			//	nilnul.num.real.matrix.Eq8quotient.Singleton.Equals(
			//		inverted8literal,inverted
			//	)	
			//);

			Assert.IsTrue(
				nilnul.num.real.matrix.be_._CanonicalX.Be(
					nilnul.num.real.matrix.bi_._MultiX.Multiply(
					m,inverted
					)
				)	
			);


		}
	}
}
