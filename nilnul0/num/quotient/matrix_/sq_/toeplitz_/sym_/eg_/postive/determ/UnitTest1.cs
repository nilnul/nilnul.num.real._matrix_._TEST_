using Microsoft.VisualStudio.TestTools.UnitTesting;
using nilnul.obj.str;
using System;
using System.Linq;
using System.Numerics;

namespace nilnul.num.matrix_.sq_.toeplitz_.sym_.eg_.postive.determ
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			int[,] f(int n) {
				//var m = new int[n, n];

				//for (int i = 0; i < n; i++)
				//{
				//	for (int j = 0; j < n; j++)
				//	{
				//		m[i, j] = (i - j + n) % n + 1;
				//	}
				//}

				return nilnul.num.real.matrix_.sq_.toeplitz_._SymmetricX.ToSymmetric_0tracts(
					Enumerable.Range(1,n)
				);
				return nilnul.num.real.matrix_.sq_.toeplitz_.sym_._PositionsX.Generate(
					n
				);


			}

			Q4 d(int[,] m) {
				/// by formula:
				/// 

				int n = m.GetLength(0);
				if (n==0)
				{
					return 1;
				}

				int nP = n +1;

				///math.stackexchange.com/questions/3736861/determinant-of-a-toeplitz-matrix
				///
				/// by recurrence:
				/// A [n+1] =
				///		[
				///			A[n], c[n]
				///			r[n],	1
				///		]
				///		,where r[n] = [n+1, n, n-1, ..., 2]
				///			r[n] = c[n]^T
				///		
				///  <see cref="num.real.matrix_.sq.grid_.plaid_.ii_.bloc1stInvertible.IDeterminant"/>
				///  
				/// hence determ(A[n+1]) 
				///		= determ(
				///			A[n]
				///		) (1 - r[n] /A[n]   c[n] )
				///		
				/// , where index is <see cref="nilnul.num.ord_.IPosition"/>
				///		,r[n] /A[n]   c[n]  is a scalar:
				///		= (e[n] A[n]  +  i[n] ) /A[n]   ( A[n]  e[n]^T + i[n]^T)
				///			,where e[n] is <see cref="real.vec_.IBasil"/>, and i[n] is the vector <see cref="num.real.str.be_._UnivalX"/>:1.
				///  =  e[n] A[n] e[n]^T  e[n] i[n]^T +i[n] e[n]^T + i[n] / A[n] i[n]^T
				///  = 1 + 1+ 1 +  2/(n+1) = 3 + 2/(n+1)
				///		, where A[n] (e[1] + e[n] ) = (n+1) i[n]^T
				///		 left multiply both sides by 1[n] /A[n]
				///		 ,
				///		 1[n] (e[1] + e[n] ) =  1[n] /A[n] (n+1) i[n]^T
				///		2 = (n+1) 1[n] /A[n]  i[n]^T
				///		, thus 1[n] /A[n]  i[n]^T = 2/(n+1)
				///		
				/// ; so:
				///		determ(A[n+1]) 
				///		= determ( A[n]) *(1- (3 + 2/(n+1) ) )
				///		= determ( A[n]) * ( -2 - 2/(n+1) )
				///		= determ( A[n]) * -2 ( 1 + 1/(n+1) )
				///		= determ( A[n]) * -2 ( (n+2)/(n+1) )
				///	;
				///	and we know determ( A[1]) = 1;
				///	, so by induction:
				///		determ( A[n]) = (-1)^(n-1) * 2^(n-2) * (n+1)


				return nilnul.num.integer_.unial.of_.cast_._NegOneIndicX.NegOneIndic(
					nP
				)
					*
					nP
					*
					nilnul.num.quotient.op_._IndicX.DenomNonnil(2, n-2)
				;

				return num.real.matrix_.sq_.toeplitz_.sym_.positions._DeterminantX._ToDeterminant_0width(n);
			}

			for (int i = 0; i < 10; i++)
			{
				var m = f(i);

				Q4 denomNonnil = nilnul.num.real.matrix_.sq._DeterminantX._Determinant_0sq(m);
				Assert.IsTrue(
					d(m) == denomNonnil	
				);

				Assert.IsTrue(
					num.real.matrix_.sq_.toeplitz_.sym_.positions._DeterminantX._ToDeterminant_0width(i) == denomNonnil	
				);



			}

		
		}
	}
}
