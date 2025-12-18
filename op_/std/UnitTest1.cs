using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace nilnul.num.real.matrix.op_.std
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			{
				var m = new Q[,] {
					{1,1,-2,1,4 }
					,{ 2,-1,-1,1,2}
					,
					{ 2,-3,1,-1,2}
					,
					{ 3,6,-9,7,9}

				};

				//var m1 = (Q[,])m.Clone();

				//nilnul.num.real.matrix.op_.dent_._EchelonX.EchelonForRank(ref m1);

				//Assert.IsTrue(
				//	num.real.matrix.Eq8quotient.Singleton.Equals(
				//		m1

				//		,
				//		new Q[,] {
				//			{   1,1,-2,1,4      }
				//			,{ 0,1,-1,1,0}
				//			,{ 0,0,0,1,-3}
				//			,{ 0,0,0,0,0}
				//		}
				//	)
				//);

				var vent = (Q[,])m.Clone();

				nilnul.num.real.matrix.op_.dent_.echelon_._VentX.Vent(ref vent);

				Q4[,] ventExpected = new Q[,] {
							{   1,0,-1,0,4      }
							,{ 0,1,-1,0,3}
							,{ 0,0,0,1,-3}
							,{ 0,0,0,0,0}
						};
				Assert.IsTrue(
					num.real.matrix.Eq8quotient.Singleton.Equals(
						vent

						,
						ventExpected
					)
				);

				var q = vent[1, 1];

				q.simplify();

				foreach (var item in vent)
				{
					item.simplify();

				}
	

				var colwise= nilnul.num.real.matrix_.vent.op_._StdX._StdIntoColwise_0vent(ref vent);



				var prod = num.real.matrix.bi_._MultiX._Multiply_1sociable(
					vent, colwise
				);




				var std = (Q[,])m.Clone();


nilnul.num.real.matrix.op_._StdX.Std(ref std);


				Q4[,] stdGened = nilnul.num.real.matrix_._StdX._OfRowsCols_2rank(4, 5, 3);
				Assert.IsTrue(
					num.real.matrix.Eq8quotient.Singleton.Equals(
						std

						,
						stdGened
					)
				);

				Assert.IsTrue(
					num.real.matrix.Eq8quotient.Singleton.Equals(
						prod

						,
						ventExpected
					)
				);




			}

		}
	}
}
