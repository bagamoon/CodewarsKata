using System;
using Katas.DeadAnts;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace TestProject.DeadAnts
{
	[TestFixture]
	public class KataTest
	{
		[TestCase("ant", 0, TestName = "Input_Complete_One_Should_Return_0")]
		[TestCase(" ant ", 0, TestName = "Input_Complete_One_With_Space_Should_Return_0")]
		[TestCase(null, 0, TestName = "Input_Null_Should_Return_0")]
		[TestCase("", 0, TestName = "Input_Empty_String_Should_Return_0")]
		[TestCase("an t", 1, TestName = "Input_Fractional_One_Should_Return_1")]
		[TestCase("ant ant", 0, TestName = "Input_Complete_Two_Should_Return_0")]
		[TestCase("an t an t", 2, TestName = "Input_Fractional_Two_Should_Return_2")]
		[TestCase("t..a n n  at ", 2, TestName = "Input_NonOrder_Fractional_Two_Should_Return_2")]
		[TestCase("t..a n antn  at ", 2, TestName = "Input_NonOrder_Fractional_Two_And_Complete_One_Should_Return_2")]
		[TestCase("a a a aant  a ", 5, TestName = "Input_Five_Head_And_Complete_One_Should_Return_5")]
		[TestCase("an an at aant  a ", 5, TestName = "Input_Five_Head_And_Three_Body_And_Complete_One_Should_Return_5")]
		[TestCase("an an at aant  a nnnn", 6, TestName = "Input_Five_Head_And_Six_Body_And_Complete_One_Should_Return_5")]
		public void DeadAntCountTest(string input, int expected)
		{
			AssertDeadAntsCount(input, expected);
		}

		private static void AssertDeadAntsCount(string input, int expected)
		{
			var kata = new Kata();

			var actual = kata.DeadAntCount(input);

			Assert.AreEqual(expected, actual);
		}
	}
}
