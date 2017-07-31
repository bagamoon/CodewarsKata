using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAverage
{
    public class Kata
    {
        public string AverageString(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return "n/a";

            var nums = GetNumsInString(input);

            var average = CalculateAverage(nums);
            
            return GetStr(average);
        }

        private static int CalculateAverage(IEnumerable<int> nums)
        {
            return nums.Sum() / nums.Count();
        }

        private IEnumerable<int> GetNumsInString(string input)
        {
            return input.Split(new[] {" "}, StringSplitOptions.RemoveEmptyEntries)
                        .Select(str => GetNum(str));
        }

        private int GetNum(string str)
        {
            Number number;

            Enum.TryParse(str, out number);

            return Convert.ToInt32(number);            
        }

        private string GetStr(int num)
        {
            Number number;
            if (Enum.TryParse(num.ToString(), out number))
            {
                return Enum.GetName(typeof(Number), num);
            }
            else
            {
                return String.Empty;
            }
        }
    }
}
