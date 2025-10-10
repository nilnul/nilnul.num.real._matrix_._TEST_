using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace nilnul.num.real.matrix_.sq_.bi_.antisym.sqrt
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{

			var r = new double[2, 2];

			for (int i = 0; i < 2; i++)
			{

				r[i,i]=nilnul._stat._RndX.RANDOM.NextDouble();
				for (int j = 1; j < 2; j++)
				{
					var t=nilnul._stat._RndX.RANDOM.NextDouble();
					r[i, j] = t;

					r[j, i] = -t;
				}
			}

			var sqrt = -0.5 *  num.real.matrix_.square.Determinant.Eval(r) * real.matrix_.square
		}
	}
}
