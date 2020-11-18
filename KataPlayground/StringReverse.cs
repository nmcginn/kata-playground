using System;
using System.Linq;

namespace kata_playground
{
    public partial class Kata
    {
        public static string Solution(string str)
        {
            return new string(str.Select(c => c).Reverse().ToArray());
        }
    }
}