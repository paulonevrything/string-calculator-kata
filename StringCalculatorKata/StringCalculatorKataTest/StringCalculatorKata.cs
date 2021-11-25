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
    }
}
