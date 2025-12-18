using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace nilnul.num.real.matrix.bi_.mul.at_.col9row
{
	/// <summary>
	/// R[n,1]  * R[1,m] = R[n,m]
	/// ;
	/// eg:
	///		R[n,1]  * R[1,1] = R[n,1]
	///		
	/// </summary>
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var aRows = nilnul._stat._RndX.RANDOM.Next(10);
			var aCols = 1;

			var a = new int[aRows,aCols];

			for (int i = 0; i < aRows; i++)
			{
				for (int j = 0; j < aCols; j++)
				{
					a[i, j] = nilnul._stat._RndX.RANDOM.Next(100);
				}
			}

			var bCols = nilnul._stat._RndX.RANDOM.Next(10);

			var b = new int[aCols, bCols];

			for (int i = 0; i < aCols; i++)
			{
				for (int j = 0; j < bCols; j++)
				{
					b[i, j] = nilnul._stat._RndX.RANDOM.Next(100);
				}
			}

			var c = nilnul.num.real.matrix.bi_._MultiX._Multiply_1sociable(a, b);

			Assert.AreEqual(aRows, c.GetLength(0));
			Assert.AreEqual(bCols, c.GetLength(1));


			for (int i = 0; i < aRows; i++)
			{
				for (int j = 0; j < bCols; j++)
				{

					Assert.AreEqual(a[i,0]*b[0,j], c[i, j]);
				}
			}
			/// this is <see cref="nilnul.num.real.matrix.to_.factorize_.svd"/>; the resulted matrix is rank1 matrix, and can be decomposed as col*row, which is more compressed form.

		}
	}
}
