using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace nilnul.num.real.matrix.nilnul0.num.real.vecs_.started.op_.schmidt
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			{

				var m = new Q[,] {
					{ 3,1}
					,
					{ 2,2}
				};

				var transed = nilnul.num.real.vecs_.indep.op_._SchmidtGramX._Ortho_0rows8indep(m);

				Assert.IsTrue(
					nilnul.num.real.matrix.Eq8quotient.Singleton.Equals(

						nilnul.num.real.matrix.of_._RowsX._OfRows_0started1unisize(transed)
						,
						new Q[,] {
							{ 3,1}
							,
							{ new Q(-2,5),new Q(6,5)
						}
						}
					)
				);
			}


		}
	}
}
