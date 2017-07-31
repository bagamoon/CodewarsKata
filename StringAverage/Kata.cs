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
            if (string.IsNullOrEmpty(input))
                return "n/a";

            var nums = new List<int>();
            foreach (var str in input.Split(new [] {" "}, StringSplitOptions.RemoveEmptyEntries))
            {
                nums.Add(GetNum(str));
            }

            return GetStr(nums.Sum() / nums.Count);
        }


        private int GetNum(string str)
        {
            switch (str)
            {
                case "one":
                    return 1;

                case "two":
                    return 2;

                case "three":
                    return 3;

                default:
                    return 0;
            }
        }

        private string GetStr(int num)
        {
            switch (num)
            {
                case 1:
                    return "one";

                case 2:
                    return "two";
                
                default:
                    return "";
            }
        }
    }
}
