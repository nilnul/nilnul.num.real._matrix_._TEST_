using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace nilnul.num.real.matrix_.sq_.triag_.lower_.invertible.op_._invert_.by_.substitute
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var wide = nilnul._stat._RndX.RANDOM.Next(9);

			var m = new Q[wide, wide];
			for (var i = 0; i < wide; i++)
			{
				var j = 0;
				for (; j < i; j++)
				{
					m[i, j] = nilnul.num.quotient.of_._RndX._OfRnd_0positive();
				}
				m[i, j] =nilnul.num.quotient_.unnil.of_._RndX._OfRnd_0positive();
				j++;

				for (; j < wide; j++)
				{
					m[i, j] = 0;
				}

			}

			var inverted = nilnul.num.real.matrix_.sq_.triag_.lower_.invertible.op_._invert_.by_._ForwardSubstitutionX._Invert_0lowerInvertible(
				m
			);

			var inverted8literal = nilnul.num.real.matrix_.sq_.invertible.op_._InvertX._Invert_0invertible(m);

			Assert.IsTrue(
				nilnul.num.real.matrix.Eq8quotient.Singleton.Equals(
					inverted8literal,inverted
				)	
			);

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
