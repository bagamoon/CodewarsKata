using System;
using System.Linq;

namespace Katas.DeadAnts
{
	public class Kata
	{
		private readonly string _token = "ant";

		public int DeadAntCount(string ants)
		{
			if (string.IsNullOrWhiteSpace(ants))
				return 0;

			var deadBodies = RemoveLivingAnts(ants);

			if (CheckIsAnyPartExisting(deadBodies) == false)
				return 0;

			var fractionGroup = deadBodies.Where(p => _token.Contains(p))
												   .GroupBy(p => p)
							 					   .Select(group => new
													{
														Fraction = group.Key,
														Count = group.Count()
													});

			return fractionGroup.Max(p => p.Count);
		}

		private bool CheckIsAnyPartExisting(string rest)
		{
			return rest.Any(p => _token.Contains(p));
		}

		private string RemoveLivingAnts(string ants)
		{
			return ants.Replace(_token, "");
		}
	}
}
