using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Katas.BandNameGenerator;
using NUnit.Framework;

namespace TestProject.BandNameGenerator
{
	[TestFixture]
	public class KataTest
	{
		[TestCase("Knife", "The Knife", TestName = "Input_Different_Starts_Ends_Should_Prefix_The")]
		[TestCase("banana", "The Banana", TestName = "Input_Different_Starts_Ends_and_Lower_Char_Should_Prefix_The_and_Upper_First_Char")]
		[TestCase("KUMA", "The Kuma", TestName = "Input_Different_Starts_Ends_and_Upper_Char_Should_Prefix_The_and_Upper_Only_First_Char")]
		[TestCase("tart", "Tartart", TestName = "Input_Same_Starts_Ends_Should_Repeat_Twice_and_Upper_First_Char")]
		[TestCase("SOS", "Sosos", TestName = "Input_Same_Starts_Ends_and_Upper_Char_Should_Repeat_Twice_and_Upper_Only_First_Char")]
		[TestCase("X", "X", TestName = "Input_Only_One_Char_Should_Return_Same_Result")]
		public void BandNameGeneratorTest(string input, string expected)
		{
			AssertBandNameGenerator(input, expected);
		}

		private void AssertBandNameGenerator(string input, string expected)
		{
			var kata = new Kata();
			var actual = kata.BandNameGenerator(input);
			Assert.AreEqual(expected, actual);
		}
	}
}
