using System;

namespace StringCalculatorKata
{
    public class StringCalculator
    {
        public static int Add(string numbers)
        {

            string[] parts = numbers.Split(',');
            int result = 0;

            foreach(string part in parts)
            {
                int.TryParse(part, out int number);

                if(number < 0)
                {
                    throw new ArgumentException("Negative numbers are not allowed");
                }

                if(number <= 1000)
                {
                    result += number;
                }
            }

            return result;
        }
    }
}