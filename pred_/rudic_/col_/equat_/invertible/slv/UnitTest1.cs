using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using nilnul.num.real.matrix.bi_;

namespace nilnul.num.real.matrix.pred_.rudic_.col_.equat_.invertible.slv
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{

			void t(Q[,] invertible, Q[] b) {

				var o = nilnul.num.real.matrix_.sq_.invertible.op_._InvertX._Invert_0invertible(invertible)._Multiply_1sociable(b);

				/// note A\ = A*  / |A|
				/// 
				/// so A\b = A^*  b /|A|
				///		= |A|\ [
				///			[
				///				cofactor00, cofactor10, cofactor20,..., cofactor[n-1,0]    ] . b		# which is replace the first row of A^* with b; or, the determinant of A with the first col replaced by b
				///				,
				///				
				///				cofactor01, cofactor11, cofactor21,..., cofactor[n-1,1]    ] . b		# which is replace the second row of A^* with b; or, the determinant of A with the second col replaced by b
				///				,
				///				...
				///			]
				///		=
			}
		}
	}
}
