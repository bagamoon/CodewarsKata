using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Katas.TwoSum;
using NUnit.Framework;

namespace TestProject.TwoSum
{
	[TestFixture]
	public class KataTest
	{
		[Test]
		public void Input_Two_Items_And_Their_Sum_As_Target_Should_Retun_0_1()
		{
			var input = new int[] {4, 7};
			var target = 11;
			var expected = new int[] {0, 1};

			AssertTwoSum(input, target, expected);
		}

		[Test]
		public void Input_Duplicate_Items_And_Their_Sum_As_Target_Should_Retun_0_1()
		{
			var input = new int[] { 3, 3 };
			var target = 6;
			var expected = new int[] { 0, 1 };

			AssertTwoSum(input, target, expected);
		}

		[Test]
		public void Input_Item_And_Its_Double_As_Target_Should_Return_Correct_Indexs()
		{
			var input = new int[] { 3, 2, 4 };
			var target = 6;
			var expected = new int[] { 1, 2 };

			AssertTwoSum(input, target, expected);
		}

		private void AssertTwoSum(int[] input, int target, int[] expected)
		{
			var kata = new Kata();

			var actual = kata.TwoSum(input, target);

			Assert.AreEqual(expected, actual);
		}
	}
}
