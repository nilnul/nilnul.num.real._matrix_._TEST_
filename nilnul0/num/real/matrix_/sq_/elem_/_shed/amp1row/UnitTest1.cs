using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace nilnul.num.real.matrix_.sq_.diag_._shred.amp1row
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			try
			{
				var v = nilnul.num.real.matrix_.sq_.diag_._shred._AmplifyOneRowX._AmpleOneRow_0wide_1row(0, 0, 0);

				throw new Exception();
			}
			catch (Exception)
			{


			}
			try
			{
				var v = nilnul.num.real.matrix_.sq_.diag_._shred._AmplifyOneRowX._AmpleOneRow_0wide_1row(0, 0, 1);

				throw new Exception();
			}
			catch (Exception)
			{


			}
			try
			{
				var v = nilnul.num.real.matrix_.sq_.diag_._shred._AmplifyOneRowX._AmpleOneRow_0wide_1row(0, 0, 2);

				throw new Exception();
			}
			catch (Exception)
			{


			}

			{
				var v = nilnul.num.real.matrix_.sq_.diag_._shred._AmplifyOneRowX._AmpleOneRow_0wide_1row(1, 0, 2);
				Assert.IsTrue(
					nilnul.num.real.matrix.Eq8quotient.Singleton.Equals(
						v
						,
						new Q[,] { { 2 } }
					)
				);
			}


			{
				var v = nilnul.num.real.matrix_.sq_.diag_._shred._AmplifyOneRowX._AmpleOneRow_0wide_1row(1, 0, 0);
				Assert.IsTrue(
					nilnul.num.real.matrix.Eq8quotient.Singleton.Equals(
						v
						,
						new Q[,] { { 0 } }
					)
				);
			}

			{
				var v = nilnul.num.real.matrix_.sq_.diag_._shred._AmplifyOneRowX._AmpleOneRow_0wide_1row(1, 0, 1);
				Assert.IsTrue(
					nilnul.num.real.matrix.Eq8quotient.Singleton.Equals(
						v
						,
						new Q[,] { { 1 } }
					)
				);
			}
			{
				var v = nilnul.num.real.matrix_.sq_.diag_._shred._AmplifyOneRowX._AmpleOneRow_0wide_1row(2, 0, 2);
				Assert.IsTrue(
					nilnul.num.real.matrix.Eq8quotient.Singleton.Equals(
						v
						,
						new Q[,] { { 2,0 },{ 0,1} }
					)
				);
			}
			{
				var v = nilnul.num.real.matrix_.sq_.diag_._shred._AmplifyOneRowX._AmpleOneRow_0wide_1row(2, 1, 2);
				Assert.IsTrue(
					nilnul.num.real.matrix.Eq8quotient.Singleton.Equals(
						v
						,
						new Q[,] { { 1,0 },{ 0,2} }
					)
				);
			}
			{
				var v = nilnul.num.real.matrix_.sq_.diag_._shred._AmplifyOneRowX._AmpleOneRow_0wide_1row(3, 0, 2);
				Assert.IsTrue(
					nilnul.num.real.matrix.Eq8quotient.Singleton.Equals(
						v
						,
						new Q[,] { { 2,0,0 },{ 0,1,0}, { 0,0,1} }
					)
				);
			}

			{
				var v = nilnul.num.real.matrix_.sq_.diag_._shred._AmplifyOneRowX._AmpleOneRow_0wide_1row(3, 1, 2);
				Assert.IsTrue(
					nilnul.num.real.matrix.Eq8quotient.Singleton.Equals(
						v
						,
						new Q[,] { { 1,0,0 },{ 0,2,0}, { 0,0,1} }
					)
				);
			}

			{
				var v = nilnul.num.real.matrix_.sq_.diag_._shred._AmplifyOneRowX._AmpleOneRow_0wide_1row(3, 2, 2);
				Assert.IsTrue(
					nilnul.num.real.matrix.Eq8quotient.Singleton.Equals(
						v
						,
						new Q[,] { { 1,0,0 },{ 0,1,0}, { 0,0,2} }
					)
				);
			}

		}
	}
}
