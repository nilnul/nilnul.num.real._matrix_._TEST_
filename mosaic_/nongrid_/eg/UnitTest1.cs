using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace nilnul.num.real.matrix._test.mosaic_.nongrid_.eg
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{

			var a = new double[,][,] {
				{
					new double[,]{ },
					new double[2,3]{
						{
							1,2,3
						}
						,
						{
							4,5,6
						}
					}
					,
					new double[3,2]{
						{
							2,3
						}
						,
						{
							5,6
						}
						,
						{
							5,6
						}
					}
				}
				,
				{
					new double[,]{
						{
							1
						}
						,
						{
							4
						}
					}
					,
					new double[,]{
						{
							2,3
						}
						,
						{
							5,6
						}
						
					}
					,
					new double[,]{
						{ 7,8}
					}
				}
				,
				{
					new double[,]{
						{ 1,2}
					},
					new double[,]{
						{10 }
					},
					new double[,]{

					},

				}
			};
		}
	}
}
