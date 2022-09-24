using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

namespace nilnul.num.real.matrix._test.square_
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void Determinant()
		{
			var square = new nilnul.num.real.matrix_.Square1(
				4563, 2138, 8978, 1026,
7890, 1237, 8662, 2048,
1140 ,3450 ,9975 ,7824,
2884, 6782 ,3686, 4589

			);

			var d = nilnul.num.real.matrix_.square.aggregate_._DeterminantX.Determinant(square);

			Debug.WriteLine(d);

			 
		}
	}
}
