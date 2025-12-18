using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.of_
{
	/// <summary>
	/// for testing
	/// </summary>
	static public class _RndX
	{
		static public Q4 _OfRnd_0positive(int max = int.MaxValue)
		{
			var d = nilnul._stat._RndX.RANDOM.Next(max);

			var sign = nilnul._stat._RndX.RANDOM.Next(2);
			if (d ==0)
			{
				if (sign ==0)
				{
					return max;// int.MaxValue; /// or 0;

				}
				return -max;// int.MaxValue; /// or 0;
			}

			var n = nilnul._stat._RndX.RANDOM.Next(max);

			if (sign ==0)
			{
				return -new quotient_.DenomNonnil(n, d);

			}

			return new quotient_.DenomNonnil(n, d);
		}


	}
}
