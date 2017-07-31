using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAverage
{
    public class Kata
    {
        private readonly string _invalidInputResult = "n/a";

        public string AverageString(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return _invalidInputResult;

            var strings = GetStringsFromInput(input);

            if (CheckAnyInvalid(strings))
                return _invalidInputResult;

            var nums = GetNumbersFromStrings(strings);

            return GetStr(GetAverage(nums));
        }

        private int GetAverage(IEnumerable<int> nums)
        {
            return Convert.ToInt32(Math.Floor(nums.Average()));
        }

        private bool CheckAnyInvalid(IEnumerable<string> strings)
        {
            var names = Enum.GetNames(typeof(Number));

            return strings.Any(str => names.Contains(str) == false);
        }

        private IEnumerable<string> GetStringsFromInput(string input)
        {
            return input.Split(new[] {" "}, StringSplitOptions.RemoveEmptyEntries);
        }

        private IEnumerable<int> GetNumbersFromStrings(IEnumerable<string> strings)
        {
            return strings.Select(str => GetNum(str));
        }

        private int GetNum(string str)
        {                        
            return Convert.ToInt32(Enum.Parse(typeof(Number), str));
        }

        private string GetStr(int num)
        {
            return Enum.GetName(typeof(Number), num);            
        }
    }
}
