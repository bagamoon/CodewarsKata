using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Katas.CountingDuplicates;
using NUnit.Framework;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace TestProject.CountingDuplicates
{
	public class KataTest
	{
		[TestCase("", 0, TestName = "Input_Empty_String_Should_Return_0")]
		[TestCase(null, 0, TestName = "Input_Null_Should_Return_0")]
		[TestCase("aa", 1, TestName = "Input_Two_Lower_Same_Char_Should_Return_1")]
		[TestCase("aA", 1, TestName = "Input_Two_Lower_And_Upper_Same_Char_Should_Return_1")]
		[TestCase("ab", 0, TestName = "Input_Two_Different_Char_Should_Return_0")]
		[TestCase("aAAa", 1, TestName = "Input_Four_Lower_And_Upper_Same_Char_Should_Return_1")]
		[TestCase("aAAabbBBb", 2, TestName = "Input_Two_Pairs_Lower_And_Upper_Char_Should_Return_2")]
		[TestCase("aAAabbBBbcDEf", 2, TestName = "Input_Two_Pairs_Lower_And_Upper_And_Other_Different_Char_Should_Return_2")]
		public void BandNameGeneratorTest(string input, int expected)
		{
			AssertBandNameGenerator(input, expected);
		}

		private void AssertBandNameGenerator(string input, int expected)
		{
			var kata = new Kata();
			var actual = kata.DuplicateCount(input);
			Assert.AreEqual(expected, actual);
		}
	}
}
