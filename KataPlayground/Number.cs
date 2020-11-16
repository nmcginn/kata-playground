using System;
using System.Linq;

namespace kata_playground
{
    public class Number
    {
        public int DigitalRoot(int v)
        {
            var sum = v.ToString().ToCharArray().Select(n => int.Parse(n.ToString())).Sum();
            if (sum >= 10)
                return DigitalRoot(sum);
            return sum;
        }
    }
}