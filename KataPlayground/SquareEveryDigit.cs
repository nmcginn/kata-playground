using System;
using System.Linq;

namespace kata_playground
{
    public partial class Kata
    {
        public static int SquareDigits(int n)
        {
            return int.Parse(
                string.Concat(n
                    .ToString()
                    .ToCharArray()
                    .Select(x => int.Parse(x.ToString()))
                    .Select(x => x * x)
                    .Select(x => x.ToString())));
        }
    }
}