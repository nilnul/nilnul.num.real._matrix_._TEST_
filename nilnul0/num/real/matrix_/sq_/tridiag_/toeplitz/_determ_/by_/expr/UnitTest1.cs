using Microsoft.VisualStudio.TestTools.UnitTesting;
using nilnul.bit.exprs_;
using nilnul.obj;
using System;
using System.Linq;

namespace nilnul.num.real.matrix_.sq_.tridiag_.toeplitz._determ_.by_.expr
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var c00 = 2;
			var c01 = 3;
			var c10 = 4;

			Enumerable.Range(
				0, 10
			).Each(
					n =>
					{
						var c00 = nilnul.num.quotient.of_._RndX._OfRnd_0positive(100);
						var c01 = nilnul.num.quotient.of_._RndX._OfRnd_0positive(100);
						var c10 = nilnul.num.quotient.of_._RndX._OfRnd_0positive(100);

						var tridiag = tridiag_._ToeplitzX.Generate(n, c00, c01, c10);

						var determ = num.real.matrix_.sq._DeterminantX._Determinant_0sq(tridiag);

						var d = sq_.tridiag_.toeplitz._determ_.by_._ByExprX._Determinant_ofTridiagToeplitz(
							n, c00, c01, c10
						);
						Assert.IsTrue(
							determ == d	
						);
						Assert.IsTrue(
							determ == by_._ByRecurX._Determinant_ofTridiagToeplitz(n,c00,c01,c10)	
						);

						Assert.IsTrue(
							determ == matrix_.sq_.tridiag._DeterminantX._Determinant_0tridiag(tridiag)	
						);


					}
			);

		}
	}
}
