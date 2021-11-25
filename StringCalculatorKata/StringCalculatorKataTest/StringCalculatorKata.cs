using NUnit.Framework;
using StringCalculatorKata;
using System;
using System.Collections.Generic;
using System.Text;

namespace StringCalculatorKataTest
{
    class StringCalculatorKata
    {

        [Test]
        public void Add_EmptyStringAsParam_ReturnsZero()
        {

            Assert.AreEqual(0, StringCalculator.Add(string.Empty));
        }

        [Test]
        public void Add_StringContainingSingleNumber_ReturnsTheNumberItself()
        {

            Assert.AreEqual(5, StringCalculator.Add("5"));
        }

        [Test]
        public void Add_TwoNumbersSeparatedByComma_ReturnsTheirSum()
        {
            
            string numbers = "7,8";

            int expectedResult = 15;

            Assert.AreEqual(expectedResult, StringCalculator.Add(numbers));
        }

        [Test]
        public void Add_ThreeNumbersSeparatedByCommas_ReturnsTheirSum()
        {

            string numbers = "1, 2, 3";
            int expectedResult = 6;
            Assert.AreEqual(expectedResult, StringCalculator.Add(numbers));
        }
        
        [TestCase("1,2,3,4", 10)]
        [TestCase("8,7,20", 35)]
        [TestCase("5,0,4,1001", 9)]
        [TestCase("5,0,4,1000", 1009)]
        [TestCase("26,6,90", 122)]
        public void Add_MoreThanThreeNumberSeparatedByCommas_ShouldReturnTheirSum(string input, int result)
        {
            Assert.AreEqual(result, StringCalculator.Add(input));
        }

        [TestCase("1,2,3,4,5,-5")]
        [TestCase("-1,1,2,9")]
        [TestCase("5,6,8,-5")]
        public void Add_StringContainingNegativeNumbers_ThrowsArgumentException(string numbers)
        {
            Assert.Throws<ArgumentException>(() => StringCalculator.Add(numbers));
        }
    }
}
