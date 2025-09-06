using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace nilnul.num.real._matrix_._TEST_.nilnul0.num.integer.matrix.co_.sociable.multi
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var x = new int[,] {
				{1,1 }
				,
				{ -1,1}
			};

			var sqed = nilnul.num.integer.matrix.co_.sociable._MultiX._Multi_0sq_1isosize(x,x);

			Assert.IsTrue(
				nilnul.num.integer.matrix.Eq.Unison._eq_assumeSameSize(
					sqed , new[,] {
						{ 0,2}
						,
						{ -2,0}
					} 
				)
			);
		}
	}
}
