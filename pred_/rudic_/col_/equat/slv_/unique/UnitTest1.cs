using Microsoft.VisualStudio.TestTools.UnitTesting;
using nilnul.txt.be_;
using System;

namespace nilnul.num.real.matrix.pred_.rudic_.col_.equat.slv
{

	/// <summary>
	/// 这是 
	///		黄振东、陆建华 写的《线性代数》教材 
	///		p5习题第一题；
	/// 至于第二题，请参见本文件旁的另一个文件
	/// </summary>
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var augmented = new Q[,] {
				{ 1,-2,1,0}
				,
				{ 0,2,-8,8}
				,
				{-4,5,9,-9 }
			};
			var slv = nilnul.num.real.matrix.pred_.rudic_.col_.equat._slv_.by_._ByRowReductionX.Solve(
				augmented
			);

			Assert.IsTrue(

				nilnul.num.real.str.Eq8quotient.Singleton.Equals(
					slv.Value.drift
					,
					[29,16,3]
				)
			);

			Assert.IsTrue(
				nilnul.num.real.matrix.re_._EquiHullX.Re(
					slv.Value.husk
					,
					nilnul.num.real.matrix_.vacant_._PortraitX.Quotient(3)
					
				)
			);


			void v(Q x1, Q x2, Q x3)
			{
				///第一个约束条件
				///
				var constraint0 = x1          -2*x2   + x3    ==0;

				var constraint1 = 2*x2    -8*x3   == 8;

				/// constraint2
				var constraint2 = -4 * x1     +5*x2   +9*x3   == -9;

				///消元：
				///
				/// x1 :
				/// 用 constraint0 *4, 加到 constraint2
				/// 
				/// 

				constraint2 =   (-2*4 + 5)*x2 + (1*4 + 9)*x3 == -9;
				constraint2 =   (-3)*x2 + (13)*x3 == -9;

				/// x2 :
				/// 把 constraint1的第一个   非0系数（pivot）  化为1
				/// 
				/// 
				constraint1 =              2/2 *x2 -8/2*x3 == 8/2;
				constraint1 =              x2  -4*x3   == 4;


				/// x3 :
				///		c2 -= 3*c1
				/// 
				/// 
				constraint2 =   (-3 - -3)*x2 + (13 - -3* -4)*x3 == -9 - -3*4;

				constraint2 =   x3 == 3;


				/// 把x3代入 c1, in other words, 
				///   c1 -=  c2*-4
				/// 
				constraint1 = x2 == 4 -3 * -4;
				constraint1 = x2 ==16;

				/// 把x2，x1带入 c0
				/// c0 -= -2 * c1    +  1 * c2

				constraint0 = x1 ==0 - (-2 *16 + 1 *3);

				constraint0 = x1 == 29;







			}

		}
	}
}
