using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace nilnul.num.real.matrix.nilnul0.num.real.matrix_.sq.be_.normal
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
					{1, -1},
					{1, 1},

				};

				

				Assert.IsTrue(
					nilnul.num.real.matrix_.sq.be_._NormalX._Be_0square(a)
				);
			}
		}
	}
}
