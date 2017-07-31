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
        public void AverageStringTest(string input, string expected)
        {
            var kata = new Kata();

            var actual = kata.AverageString(input);

            Assert.AreEqual(expected, actual);
        }
    }
}
