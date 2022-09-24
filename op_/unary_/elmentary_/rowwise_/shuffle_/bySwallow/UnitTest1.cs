using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;

namespace nilnul.num.real.matrix._test.op_.unary_.elmentary_.rowwise_.shuffle_.bySwallow
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{

			var rnd = new System.Random();

			var m = new int[4,5];

			for (int i = 0; i < m.GetLength(0); i++)
			{
				for (int j = 0; j < m.GetLength(1); j++)
				{
					m[i, j] = rnd.Next( 100);
				}
			}

			var row1 = rnd.Next(
				m.GetLength(0)
			);

			var row2 = rnd.Next( m.GetLength(0));

			var shuffled = nilnul.num.real.matrix.op_.unary_.elementary_.rowwise_._ShuffleX._New_assumeValid(
				m,row1,row2
			);

			var bySwallowed= nilnul.num.real.matrix.op_.unary_.elementary_.rowwise_.shuffle_._ByShearX._New_assumeValid(
				m,row1,row2
			);

			Debug.Assert(
				 nilnul.num.real.matrix.Eq4int.Lazy.Equals( shuffled,bySwallowed)
				);

			/// todo: further investigate.

			
		}
	}
}
