using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace nilnul.num.real.matrix.kernel.eigen
{
	[TestClass]
	public class UnitTest11
	{
		[TestMethod]
		public void TestMethod1()
		{
			V(
				nilnul.num.real.matrix_._VanityX.Quotient
				,
				nilnul.num.real.matrix_._VanityX.Quotient

			);

			V(
				nilnul.num.real.matrix_.vacant_._LandscapeX.Quotient(1)
				,

				new Q[,] { { 1} }

			);

			V(
				nilnul.num.real.matrix_.vacant_._LandscapeX.Quotient(2)
				,
				new Q[,] { { 1,0},{ 0, 1 } }

			);

			V(
				nilnul.num.real.matrix_.vacant_._LandscapeX.Quotient(3)
				,

				nilnul.num.real.matrix_.sq_._CanonicalX.Generate8quotient(3)
			);

			V(
				nilnul.num.real.matrix_.vacant_._LandscapeX.Quotient(4)
				,
				nilnul.num.real.matrix_.sq_._CanonicalX.Generate8quotient(4)

			);

			V(
				nilnul.num.real.matrix_.vacant_._PortraitX.Quotient(0)
				,
				nilnul.num.real.matrix_.vacant_._PortraitX.Quotient(0)
			);

			V(
				nilnul.num.real.matrix_.vacant_._PortraitX.Quotient(1)
				,
				nilnul.num.real.matrix_.vacant_._PortraitX.Quotient(0)
			);

			V(
				nilnul.num.real.matrix_.vacant_._PortraitX.Quotient(2)
				,
				nilnul.num.real.matrix_.vacant_._PortraitX.Quotient(0)
			);

			V(
				nilnul.num.real.matrix_.vacant_._PortraitX.Quotient(3)
				,
				nilnul.num.real.matrix_.vacant_._PortraitX.Quotient(0)
			);

			V(
				nilnul.num.real.matrix_.vacant_._PortraitX.Quotient(4)
				,
				nilnul.num.real.matrix_.vacant_._PortraitX.Quotient(0)
			);


			V(
				new Q[1, 1] { { 0} }
				,
				new Q[1, 1] { { 1} }
			);

			V(
				new Q[1, 1] { { Q.NegOne} }
				,
				new Q[1, 0] { { } }
			);

			V(
				new Q[1, 1] { { new Q(1,2)} }
				,
				new Q[1, 0] { { } }
				//new Q[0, 1] {  }
			);

			V(
				new Q[1, 1] { { new Q(-1,2)} }
				,
				new Q[1, 0] { { } }
				//new Q[0, 1] {  }
			);
			V(
				new Q[1, 1] { { new Q(2)} }
				,
				new Q[1, 0] { { } }
				//new Q[0, 1] { }
			);


		}

		static void V(Q[,] m, Q[,] expected) {
		


			var k = nilnul.num.real.matrix.op_._kernel_.by_._ByRowReductionX.Kernel(m);
			Assert.IsTrue(
				nilnul.num.real.matrix.cols.re_._equihull_.by_._ByTransposeX.Re(
					k
					,
					expected
				)
			);



		}
	}
}
