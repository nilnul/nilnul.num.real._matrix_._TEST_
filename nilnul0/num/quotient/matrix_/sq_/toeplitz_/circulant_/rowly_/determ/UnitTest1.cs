using Microsoft.VisualStudio.TestTools.UnitTesting;
using nilnul.obj.str;
using System;
using System.Linq;
using System.Numerics;

namespace nilnul.num.matrix_.sq_.toeplitz_.circulant_.rowly_.positions.determ
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
		


			var expecteds = ((BigInteger[]) [1,1, -3, 18, -160, 1875, -27216, 470596, -9437184, 215233605, -5500000000, 155624547606, -4829554409472, 163086595857367, -5952860799406080, 233543408203125000,
				BigInteger.Parse(
				"-9799832789158199296"
				)
				, 
				BigInteger.Parse(
				"437950726881001816329")
				, 
				BigInteger.Parse(
				"-20766159817517617053696")
				,
				BigInteger.Parse(
				"1041273502979112415328410")
			]).Take(12) .ToArray();
			Enumerable.Range(0, expecteds.Length).Select(
				n=> num.real.matrix_.sq_.toeplitz_.circulant_.rowwise_._PositionsX.Generate(n)
			).Each(
				(d,i)=>
				Assert.IsTrue(
					//nilnul.num.real.matrix_.sq._DeterminantX._Determinant_0sq
					nilnul.num.real.matrix_.sq._determ_.by_._ByPermuteX._Determ_0sq
					
					(
					d) == expecteds[i]
				)
			);
		}
	}
}
