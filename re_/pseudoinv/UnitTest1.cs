using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace nilnul.num.real.matrix.re_.pseudoinv
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			{
				var a = new Q[,]
				{
				{1, 2},

				};

				var b = new Q[,]
				{
				{
					new Q(1,5)
				}
				,
				{
					new Q(2,5)
				}
				};

				Assert.IsTrue(
					nilnul.num.real.matrix.re_._PseudoInverseX.Be(a, b)
				);
			}

			{
				var a = new int[,]
				{
					{1, 0},
					{0,0 }

				};

				var b = a;

				Assert.IsTrue(
					nilnul.num.real.matrix.re_._PseudoInverseX.Re(a, b)
				);
			}
			{
				var a = new Q[,]
				{
				{1, 1},
				{1, 1},

				};

				var b = new Q[,]
				{
				{
					new Q(1,4),new Q(1,4),
				}
				,
				{
					new Q(1,4),new Q(1,4),
				}
				};

				Assert.IsTrue(
					nilnul.num.real.matrix.re_._PseudoInverseX.Be(a, b)
				);
			}


		}
	}
}
