using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace nilnul.num.matrix_.sq_.toeplitz_.sym_.eg_.postive
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			int[,] f(int n) {
				var m = new int[n, n];

				for (int i = 0; i < n; i++)
				{
					for (int j = 0; j < n; j++)
					{
						m[i, j] = (i - j + n) % n + 1;
					}
				}

				return nilnul.num.real.matrix_.sq_.toeplitz_._SymmetricX.ToSymmetric_0tracts(
					Enumerable.Range(1,n)
				);
			}
		}
	}
}
