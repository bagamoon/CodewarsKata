using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using StringAverage;
using Assert = NUnit.Framework.Assert;

namespace TestProject
{
    [TestFixture]
    public class KataTest
    {
        [TestCase("", "n/a", TestName = "Input_Empty_String_Should_Return_n/a")]
        [TestCase("one three", "two", TestName = "Input_Divisible_Total_Should_Return_Correct_Result")]
        [TestCase("one two", "one", TestName = "Input_Nondivisible_Total_Should_Return_Floor_Result")]
        [TestCase("four", "four", TestName = "Input_One_Num_Should_Return_Same_Result")]
        [TestCase("zero nine five two", "four")]
        [TestCase("four six two three", "three")]
        [TestCase("one two three four five", "three")]
        [TestCase("five four", "four")]
        [TestCase("zero zero zero zero zero", "zero")]
        [TestCase("one one eight one", "two")]
        public void AverageStringTest(string input, string expected)
        {
            AssertAverage(input, expected);            
        }

        private static void AssertAverage(string input, string expected)
        {
            var kata = new Kata();

            var actual = kata.AverageString(input);

            Assert.AreEqual(expected, actual);
        }
    }
}
