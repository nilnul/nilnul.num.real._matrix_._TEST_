using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace nilnul.num.real.matrix_.sq.calc
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var a = new nilnul.num.RealI_onQuotient[2, 2] {
				{ new nilnul.num.real_.Quotient_denomNonnil(3) ,new nilnul.num.real_.Quotient_denomNonnil(-2)}
				,
				{ new nilnul.num.real_.Quotient_denomNonnil(1) ,new nilnul.num.real_.Quotient_denomNonnil(2)}

			};

			var b = new nilnul.num.RealI_onQuotient[2, 2] {
				{ new nilnul.num.real_.Quotient_denomNonnil(2) ,new nilnul.num.real_.Quotient_denomNonnil(-4)}
				,
				{ new nilnul.num.real_.Quotient_denomNonnil(2) ,new nilnul.num.real_.Quotient_denomNonnil(0)}

			};

			var c = new nilnul.num.RealI_onQuotient[2, 2] {
				{ new nilnul.num.real_.Quotient_denomNonnil(1) ,new nilnul.num.real_.Quotient_denomNonnil(2)}
				,
				{ new nilnul.num.real_.Quotient_denomNonnil(-1) ,new nilnul.num.real_.Quotient_denomNonnil(2)}

			};


			var a4=
				nilnul.num.real.matrix.bi_._AddX._Add_1isosize(
					nilnul.num.real.matrix_.sq.op_._PonentX._Ponent_0regular_1unneg(a, 4)
					,
					nilnul.num.real.matrix_.sq.op_._PonentX._Ponent_0regular_1unneg(b, 4)
				);

			var c4 =
			nilnul.num.real.matrix_.sq.op_._PonentX._Ponent_0regular_1unneg(c, 4);

			var eq = nilnul.num.real.matrix.Eq.Singleton._eq_assumeSameSize(a4, c4);

			Assert.IsTrue(eq);

		}


		[TestMethod]
		public void TestMethod2()
		{
			var a = new int[,]{
				{
					1,6
				}
				,{
					9,4
				}
			}
			;

			var b =new int[,]{
				{
					8,6
				}
				,{
					1,7
				}
			}
			; 

			var c =new int[,]{
				{
					5,10
				}
				,{
					5,5
				}
			}
			;  


			var a4=
				nilnul.num.real.matrix.bi_._AddX._Add_1isosize(
					nilnul.num.real.matrix_.sq.op_._PonentX._Ponent_0regular_1unneg(a, 4)
					,
					nilnul.num.real.matrix_.sq.op_._PonentX._Ponent_0regular_1unneg(b, 4)
				);

			var c4 =
			nilnul.num.real.matrix_.sq.op_._PonentX._Ponent_0regular_1unneg(c, 4);

			var eq = nilnul.num.real.matrix.Eq4int.Singleton._eq_assumeSameSize(a4, c4);

			Assert.IsTrue(eq);

		}

		[TestMethod]
		public void TestMethod3()
		{
			var a = new int[,]{
				{
					2,1
				}
				,{
					4,6
				}
			}
			;

			var b =new int[,]{
				{
					6,4
				}
				,{
					1,2
				}
			}
			; 

			var c =new int[,]{
				{
					6,2
				}
				,{
					2,6
				}
			}
			;  

			var a4=
				nilnul.num.real.matrix.bi_._AddX._Add_1isosize(
					nilnul.num.real.matrix_.sq.op_._PonentX._Ponent_0regular_1unneg(a, 4)
					,
					nilnul.num.real.matrix_.sq.op_._PonentX._Ponent_0regular_1unneg(b, 4)
				);

			var c4 =
			nilnul.num.real.matrix_.sq.op_._PonentX._Ponent_0regular_1unneg(c, 4);

			var eq = nilnul.num.real.matrix.Eq4int.Singleton._eq_assumeSameSize(a4, c4);

			Assert.IsTrue(eq);

		}

	}
}
