using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace nilnul.num.real.matrix_.sq_.vander.determinant
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			v(
				[], 1
			);
			v(
				[0.6]	/// generate a vandermonde: [1]; <see cref="num.real.matrix_.sq_._VandermondeX.Matrix(IEnumerable{double})"/>

				,1
			);

			v(
				[0.5,0.3], -.2
			);

			v(
				[0.4, 0.7, 0.8] 
					
				
			);
			v(
				[0.4, 0.7, 0.8,1.1] 
					
				
			);

			v(
				[0.4, 0.7, 0.8,1.1,9] 
					
				
			);

			v(
				[0.4, 0.7, 0.8,1.1,9,9],0 
					
				
			);


		}
		void v(IEnumerable<double> x) {
			v(
				x,
				nilnul.num.real.matrix_.sq.Determinant.Eval(
					num.real.matrix_.sq_._VandermondeX.Matrix(x)
				)
			);
		}

		void v(IEnumerable<double> x, double expected) {
			Assert.IsTrue(
				nilnul.num.real.re_.approx_.PerKilo4Dbl.Singleton.re(
					vander._DeterminantX.Determinant(x)
					,
					expected
				)
			);
		}


	}
}
