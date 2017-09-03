using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katas.TwoSum
{
	public class Kata
	{
		public int[] TwoSum(int[] nums, int target)
		{
			var dict = nums.Select((p, i) => new {Index = i, Value = p})
								.GroupBy(p => p.Value)
								.ToDictionary(p => p.Key, p => p.First().Index);

			for (int i = 0; i < nums.Length; i++)
			{
				int diff = target - nums[i];
				int pairIndex;
				if (dict.TryGetValue(diff, out pairIndex) && pairIndex != i)
				{
					return i < pairIndex ? new int[] {i, pairIndex} : new int[] {pairIndex, i};
				}
			}

			return new int[] {-1, -1};
		}
	}
}
