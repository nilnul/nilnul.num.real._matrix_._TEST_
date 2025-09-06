using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace nilnul.num.real.matrix.op_.rowspan_.std
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			{
				var m = new Q[,] {

				};

				var m1 =(Q[,] ) m.Clone();

				num.real.matrix.op_.rowspan_._GaussianX.Standardize(m);

				Assert.IsTrue(
					num.real.matrix.Eq8quotient.Singleton.Equals(
						m
						,
						m1
					)
				);

			}
			{
				var m = new Q[,] {
					{ 0}
				};

				var m1 =(Q[,] ) m.Clone();

				num.real.matrix.op_.rowspan_._GaussianX.Standardize(m);

				Assert.IsTrue(
					num.real.matrix.Eq8quotient.Singleton.Equals(
						m
						,
						m1
					)
				);

			}

			{
				var m = new Q[,] {
					{ 1}
				};

				var m1 =new Q[,] {
					{ 1}
				};;

				num.real.matrix.op_.rowspan_._GaussianX.Canonical(ref m);

				Assert.IsTrue(
					num.real.matrix.Eq8quotient.Singleton.Equals(
						m
						,
						m1
					)
				);

			}

			{
				var m = new Q[,] {
					{ -1}
				};

				var m1 =new Q[,] {
					{ 1}
				};;

				num.real.matrix.op_.rowspan_._GaussianX.Canonical(m);

				Assert.IsTrue(
					num.real.matrix.Eq8quotient.Singleton.Equals(
						m
						,
						m1
					)
				);

			}
			{
				var m = new Q[,] {
					{ 0,0}
				};

				var m1 =new Q[,] {
					{0, 0}
				};;

				num.real.matrix.op_.rowspan_._GaussianX.Canonical(m);

				Assert.IsTrue(
					num.real.matrix.Eq8quotient.Singleton.Equals(
						m
						,
						m1
					)
				);

			}
			{
				var m = new Q[,] {
					{ 0,-2}
				};

				var m1 =new Q[,] {
					{0, 1}
				};;

				num.real.matrix.op_.rowspan_._GaussianX.Canonical(m);

				Assert.IsTrue(
					num.real.matrix.Eq8quotient.Singleton.Equals(
						m
						,
						m1
					)
				);

			}



			{
				var m = new Q[,] {
					{
						new Q(-1,2)
					}
				};

				var m1 =new Q[,] {
					{1}
				};;

				num.real.matrix.op_.rowspan_._GaussianX.Canonical(m);

				Assert.IsTrue(
					num.real.matrix.Eq8quotient.Singleton.Equals(
						m
						,
						m1
					)
				);

			}

			{
				var m = new Q[,] {
					{
						new Q(-1,2)
						,
						new Q(-1,2)

					}
				};

				var m1 =new Q[,] {
					{1, 1}
					
				};;

				num.real.matrix.op_.rowspan_._GaussianX.Canonical(m);

				Assert.IsTrue(
					num.real.matrix.Eq8quotient.Singleton.Equals(
						m
						,
						m1
					)
				);

			}

			{
				var m = new Q[,] {
					{
						new Q(-1,2)
						,
						new Q(-3,2)

					}
				};

				var m1 =new Q[,] {
					{1, new Q( 6,2)}
	
				};;

				num.real.matrix.op_.rowspan_._GaussianX.Canonical(m);

				Assert.IsTrue(
					num.real.matrix.Eq8quotient.Singleton.Equals(
						m
						,
						m1
					)
				);

			}


			{
				var m = new Q[,] {
					{
						1,2,3

					}
					,
					{ 1,2,3}
					,
					{ 2,4,5}  /// 0, 0, -1
				};

				var m1 =new Q[,] {
					//{1, 2,3}
					{1, 2,0}

					,
					{0,0,1 }
					,
					{0,0,0 }

				};;


				num.real.matrix.op_.rowspan_._GaussianX.Canonical(m);

				Assert.IsTrue(
					num.real.matrix.Eq8quotient.Singleton.Equals(
						m
						,
						m1
					)
				);

			}

			{
				var m = new Q[,] {
					{
						1,0,4,2

					}
					,
					{ 1,2,6,2}
					,
					{ 2,0,8,8}
					,
					{2,1,9,4 }
				};

				var m1 =new Q[,] {
					{1, 0,4,2}
					,
					{0,1,1,0 }
					,
					{0,0,0 ,1}
					,
					{ 0,0,0,0}

				};;

				num.real.matrix.op_.rowspan_._GaussianX.Standardize(m);

				Assert.IsTrue(
					num.real.matrix.Eq8quotient.Singleton.Equals(
						m
						,
						m1
					)
				);

			}

			{
				var m = new Q[,] {
					{
						1,3,1,9

					}
					,
					{ 1,1,-1,1}
					,
					{3,11,5,35 }
				};

				var m1 =new Q[,] {
					{1, 0,-2,-3}
					,
					{0,1,1,4 }
					,
					{ 0,0,0,0}

				};;

				num.real.matrix.op_.rowspan_._GaussianX.Canonical(m);

				Assert.IsTrue(
					num.real.matrix.Eq8quotient.Singleton.Equals(
						m
						,
						m1
					)
				);

			}

			{
				var m = new Q[,] {
					{
						0,2,1,-1

					}
					,
					{ 0,0,3,1}
					,
					{0,0,0,0 }
				};

				var m1 =new Q[,] {
					//{0, 1,	new Q(1,2),		new Q(-1,2)}
					{0, 1,	0,		new Q(-1,2) + new Q(-1,6)}

					,
					{0,0,	1,				new Q(1,3) }
					,
					{ 0,0,0,0}

				};;

				num.real.matrix.op_.rowspan_._GaussianX.Canonical(m);

				Assert.IsTrue(
					num.real.matrix.Eq8quotient.Singleton.Equals(
						m
						,
						m1
					)
				);

			}


			{
				/// en.wikipedia.org/wiki/Gaussian_elimination
				var m = new Q[,] {
					{
						2,1,-1,8

					}
					,
					{ -3,-1,2,-11}
					,
					{-2,1,2, -3 }
				};

				var m1 =new Q[,] {
					{1, 0,  0,      2}
					,
					{ 0,1,0,3}

					,
					{0,0,	1,			-1 }

				};;

				num.real.matrix.op_.rowspan_._GaussianX.Canonical(m);

				Assert.IsTrue(
					num.real.matrix.Eq8quotient.Singleton.Equals(
						m
						,
						m1
					)
				);

			}

			{
				/// https://en.wikipedia.org/wiki/Gaussian_elimination
				var m = new Q[,] {
					{
						2,-1,0, 1,0,0

					}
					,
					{ -1,2,-1, 0,1,0}
					,
					{0,-1,2, 0,0,1}
				};

				var m1 =new Q[,] {
					{1, 0,  0,      new Q(3,4), new Q(1,2), new Q(1,4) }
					,
					{ 0,1,0,  new Q(1,2), new Q(1), new Q(1,2)}

					,
					{0,0,	1,	Q.Quarter,	Q.Inverse(2)	,Q.Quarter*3}

				};;

				num.real.matrix.op_.rowspan_._GaussianX.Canonical(m);

				Assert.IsTrue(
					num.real.matrix.Eq8quotient.Singleton.Equals(
						m
						,
						m1
					)
				);

			}

			{
				/// mathworld.wolfram.com/GaussianElimination.html
				var m = new Q[,] {
					{
						9,3,4,7

					}
					,
					{ 4,3,4,8}
					,
					{1,1,1,3}
				};

				var m1 =new Q[,] {
					{1,1,1,3 }
					,
					{ 0,-1,0,-4}

					,
					{0,0,-5,4}

				};

				num.real.matrix.op_.rowspan_._GaussianX.Canonical(m1);

				num.real.matrix.op_.rowspan_._GaussianX.Canonical(m);

				Assert.IsTrue(
					num.real.matrix.Eq8quotient.Singleton.Equals(
						m
						,
						m1
					)
				);

			}
		}
	}
}
