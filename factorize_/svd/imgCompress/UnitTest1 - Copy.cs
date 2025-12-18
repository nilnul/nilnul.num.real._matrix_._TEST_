using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace nilnul.num.real.matrix.to_.factorize_.svd.imgCompress
{

	[TestClass]
	public class UnitTest11
	{
		[TestMethod]
		public void TestMethod1()
		{
			//  https://www.youtube.com/watch?v=DG7YTlGnCEo

			/// https://github.com/luisguiserrano/singular_value_decomposition

			var m = new double[,] {
	{ 0,1,1,0,1,1,0 },
	{ 1,1,1,1,1,1,1},
	{ 1,1,1,1,1,1,1},
	{ 0,1,1,1,1,1,0},
	{ 0,0,1,1,1,0,0},
	{ 0,0,0,1,0,0,0}
	}; /// as a black/white image


			/// 
			var s =
	new double[,] {
	{ -0.36 ,-0 ,  -0.73, -0.05 , 0.56 , 0.13 }
	  ,{-0.54  ,0.35  ,0.27 ,-0.08, -0.16  ,0.69}
	  ,{-0.54  ,0.35  ,0.27, -0.08  ,0.16, -0.69}
	  ,{-0.45, -0.35, -0.27  ,0.52, -0.56, -0.13}
	  ,{-0.28 ,-0.71  ,0.18, -0.62, -0  , -0  }
	  ,{-0.08, -0.35  ,0.46  ,0.57  ,0.56  ,0.13}
			};






			var v = nilnul.num.real.matrix_._DiagonalX.Diagonal(6, 7, new double[] {
				4.74,
				1.41,
				1.41,
				0.73,0,0 });


			var d = new double[,] {

			{ -0.23 ,-0.4 , -0.46 ,-0.4 , -0.46 ,-0.4 , -0.23}
	  ,{ 0.5 ,  0.25 ,-0.25 ,-0.5 , -0.25 , 0.25 , 0.5 ,}
	  ,{ 0.39 ,-0.32 ,-0.19 , 0.65 ,-0.19 ,-0.32 , 0.39}
	  ,{-0.22 , 0.42 ,-0.44 , 0.42 ,-0.44 , 0.42 ,-0.22}
	  ,{ 0.56 ,-0.43 , 0.03 , 0,   -0.03 , 0.43 ,-0.56}
	  ,{-0.42 ,-0.55 ,-0.16 , 0,    0.16 , 0.55 , 0.42}
	  ,{-0.12 ,-0.11 , 0.69 ,-0,   -0.69 , 0.11 , 0.12   }
			};



			var prod = nilnul.num.real.matrix.str_.started_.productable._ProductX._Product_0productable(
				s, v, d
			);

			Assert.IsTrue(
				nilnul.num.real.matrix.re_.Approx4dbl1.HUNDREDTH.re(
					prod,
					m
				)
			);

		}
	}
}
