using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Numerics;
using MathNet.Numerics;
using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.LinearAlgebra.Factorization;

namespace nilnul.num.real.matrix_.sq.dich_.qr
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{

			Matrix<double> processedData = Matrix<double>.Build.Random(5, 5);
			Evd<double> eigen = processedData.Evd();

			Vector<Complex> eigenvalues = eigen.EigenValues;

			var eigenvector = eigen.EigenVectors;

		}
	}
}
