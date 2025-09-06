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

			var r = new double[2, 2] {
					{ 0,1}
				,	{ -1,0}
			};

			

			var sqrt =  new double[2, 2] {
				{ -1,1}
				, { 1,-1}
			};
		}
	}
}
