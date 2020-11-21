using System;

namespace kata_playground
{
    public partial class Kata
    {
        public static string Add(string number1, string number2)
        {
            if (number1.Length > number2.Length)
            {
                number2 = number2.PadLeft(number1.Length, '0');
            }
            else if (number2.Length > number1.Length)
            {
                number1 = number1.PadLeft(number2.Length, '0');
            }

            var result = "";
            var iterations = number1.Length;
            int carry = 0;
            for (var i = iterations - 1; i >= 0; i--)
            {
                var digit1 = int.Parse(number1[i].ToString());
                var digit2 = int.Parse(number2[i].ToString());
                result = (digit1 + digit2 + carry) % 10 + result;
                carry = (digit1 + digit2 + carry) / 10;
            }
            if (carry != 0)
                result = carry + result;

            return result;
        }
    }
}
