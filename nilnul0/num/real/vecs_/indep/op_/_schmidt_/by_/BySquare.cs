using nilnul.txt.be_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.vecs_.indep.op_._schmidt_.by_
{
	static public class _BySquareX
	{
		static public Q[,] _Ortho_0indep(Q[,] rows) {

			int high = rows.GetLength(0);

			int wide2 = high * 2;
			var t = new Q[
				high
				,
				wide2
			];

			var sq = num.real.matrix.op_._MulTransposedX.MulTranspose(rows);

			for (int i = 0; i < high; i++)
			{
				for (int j = 0; j < high; j++)
				{
					t[i, j] = sq[i, j];
					t[i, j+high] = rows[i, j];

				}

				

			}

			var std =
				//nilnul.num.real.matrix.op_._canon_.by_._GaussianX.Standardize
				nilnul.num.real.matrix.op_.dent_._EchelonX.EchelonForRank
				(ref 
				t
			);

			var r = new Q[high,high];

			for (int i = 0; i < high; i++)
			{
				for (int j = 0; j < high; j++)
				{
					r[i, j] = t[i, high + j];
				}

			}

			return r;
		}
	}
}
