using nilnul.num.quotient.matrix.op;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.vecs_.indep.op_._schmidt_.by_
{
	/// <summary>
	/// using the ceremonial gram determinant for jTh schmidt vector, using the 
	/// </summary>
	internal class ByDeterminant
	{
		///

		static public IEnumerable<Q> Vec(
			IEnumerable<Q>[] vecs
			,
			int i
		) {

			return nilnul.num.real.matrix_.sq._DeterminantX._Determinant_0square(

				nilnul.num.real.vecs.to_._GramMatrixX.ToGramMatrix(
					vecs.TakeWhile((a,j) => j!=i).ToArray()
				)

			)
				/// + other vecs
				;
		}
	}
}
