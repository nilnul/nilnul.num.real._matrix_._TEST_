using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient_.unnil.of_
{
	/// <summary>
	/// for testing
	/// </summary>
	static public class _RndX
	{
		static public Q4 _OfRnd_0positive(int max=int.MaxValue) {

			var d =nilnul._stat._RndX.RANDOM.Next(max);

			if (d ==0)
			{
				 //nilnul._stat._RndX.RANDOM.Next(2);

				return nilnul._stat._RndX.RANDOM.Next(2)==0?- max:max;// int.MaxValue; /// or 0;
			}

			var n = nilnul._stat._RndX.RANDOM.Next(1,max);

			return  nilnul._stat._RndX.RANDOM.Next(2)==0?-new quotient_.DenomNonnil(n, d):new quotient_.DenomNonnil(n, d);
		}


	}
}
