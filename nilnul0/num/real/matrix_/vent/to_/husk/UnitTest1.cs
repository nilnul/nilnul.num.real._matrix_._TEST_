using Microsoft.VisualStudio.TestTools.UnitTesting;
using nilnul.obj.matrix.op_;
using System;

namespace nilnul.num.real.matrix_.vent.to_.husk
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			{
				var m = new Q[,] {
					{	0, 1, 2,0,1		}
					,{	0, 0, 0,1,1		}
				};

				var k = nilnul.num.real.matrix_.vent.to_._KernelX._Kernel_0vent(m);

				Assert.IsTrue(
					nilnul.num.real.matrix.Eq8quotient.Singleton.Equals(
						k
						,
						new Q[,]{
							{	1,	0,	0,0,	0	}
							,{ 0,	-2,	1,0,	0}
							,{ 0,	-1,	0,-1,	1}
						}.Transpose()
					)
				
				);
				Assert.IsTrue(
					nilnul.num.real.matrix.cols.re_._equihull_.by_._ByTransposeX.Re(
						k
						,
						new Q[,]{
							{	0,	-1,	0,-1,	1}
							,{	0,	-2,	1,0,	0}
							,{	1,	0,	0,0,	0	}
						}.Transpose()
					)
				
				);

				Assert.IsTrue(
					nilnul.num.real.matrix.cols.re_._equihull_.by_._ByTransposeX.Re(
						k
						,
						new Q[,]{
							{	1,	0,	0}
							,{	0,	-2,	-1}
							,{	0,	1,	0}
							,{	0,	0,	-1}
							,{	0,	0, 1}
						}
					)
				
				);

				Assert.IsTrue(
					nilnul.num.real.matrix.cols.re_._equihull_.by_._ByTransposeX.Re(
						k
						,
						new Q[,]{
							{		0,		0,	1,}
							,{		-1,		-2,	0,}
							,{		0,		1,	0,}
							,{		-1,		0,	0,}
							,{		1,		0,	0,}
						}
					)
				
				);




			}


			{
				var m = new Q[,] {
					{	 1, 2,0,1		}
					,{	 0, 0,1,1		}
				 

				};

				var k = nilnul.num.real.matrix_.vent.to_._KernelX._Kernel_0vent(m);

				Assert.IsTrue(
					nilnul.num.real.matrix.Eq8quotient.Singleton.Equals(
						k
						,
						new Q[,]{
							{ 		-2,	1,0,	0}
							,{ 		-1,	0,-1,	1}
						}.Transpose()
					)
				
				);
			}

			{
				var m = new Q[,] {
					{	 1, 2,0		}
					,{	 0, 0,1		}
				 

				};

				var k = nilnul.num.real.matrix_.vent.to_._KernelX._Kernel_0vent(m);

				Assert.IsTrue(
					nilnul.num.real.matrix.Eq8quotient.Singleton.Equals(
						k
						,
						new Q[,]{
							{ 		-2,	1,0	}
						}.Transpose()
					)
				
				);
			}

			{
				var m = new Q[,] {
					{	 1, 2,	3,	0		}
					,{	 0, 0,	0,	1		}
				 

				};

				var k = nilnul.num.real.matrix_.vent.to_._KernelX._Kernel_0vent(m);

				Assert.IsTrue(
					nilnul.num.real.matrix.Eq8quotient.Singleton.Equals(
						k
						,
						new Q[,]{
							{ 		-2,	1,0,0	}
							,{ 		-3,	0,1,0	}


						}.Transpose()
					)
				
				);
			}



		}
	}
}
