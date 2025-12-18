using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace nilnul.num.real.matrix.grid.co_.conform
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var a = new Q[3, 3][,] {
				{ new Q[,]{ { 1 } } ,new Q[,]{ {0, 1 } } ,new Q[,]{ {-1 } }}
				,
				{ new Q[,]{ { 1 } } ,new Q[,]{ {1, 1 } } ,new Q[,]{ {0 } }}
				,
				{ new Q[,]{ { 0 }, { 1 } } ,new Q[,]{ { 1,0 },{ 1,-1} } ,new Q[,]{ {1 },{ 0} }}
				,

			};

			var b = new Q[3, 2][,] {
				{ new Q[,]{ { 1 } } ,new Q[,]{ {1, 1 } }}
				,
				{ new Q[,]{ { 1 }, { 1 } } ,new Q[,]{ {0, 1 },{ 1, 0 } } }
				,
				{ new Q[,]{  { 1 } } ,new Q[,]{ { 0,1 }} }
				,

			};

			Assert.IsTrue(
				nilnul.obj.matrix._grid.mosaic.be_._PartitionedX.IsPartitioned(a)
			);

			Assert.IsTrue(
				nilnul.obj.matrix._grid.mosaic.be_._PartitionedX.IsPartitioned(b)
			);

			Assert.IsTrue(
				nilnul.obj.matrix.re_._MultibleX.Re(a,b)
			);

			var multied = nilnul.num.real.matrix.grid.co_.conform._MultiX._Multi_01conform(a, b);

			var mul8mat = nilnul.obj.matrix.grid._DebunkX._Debunk_0grid(multied);


			Assert.IsTrue(
				nilnul.num.real.matrix.Eq8quotient.Singleton.Equals(mul8mat

				,
				 new Q[,] {
					 {1,2,0 }
					 ,{ 3,2,2}
					 ,{ 2,0,2}
					 ,{ 1,0,2}
				 }
				)
			);


		}
	}
}
