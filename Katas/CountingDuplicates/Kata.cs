using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katas.CountingDuplicates
{
	public class Kata
	{
		public int DuplicateCount(string input)
		{
			if (string.IsNullOrEmpty(input))
				return 0;

			return input.ToLower()
							.GroupBy(p => p)
							.Count(p => p.Count() > 1);
		}
	}
}
