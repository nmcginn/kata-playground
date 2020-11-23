using System;
using System.Linq;

namespace kata_playground
{
    public partial class Kata
    {
        public static string StripComments(string text, string[] commentSymbols)
        {
            var lines = text.Split(Environment.NewLine);
            var trimAfter = commentSymbols.Select(symbol => symbol.First()).ToArray();

            var trimmedLines = lines.Select(line => TrimLine(line, trimAfter));

            return string.Join(Environment.NewLine, trimmedLines);
        }

        private static string TrimLine(string line, char[] trimAfter)
        {
            if (line.IndexOfAny(trimAfter) == -1)
                return line.TrimEnd();
            return line.Substring(0, line.IndexOfAny(trimAfter)).TrimEnd();
        }
    }
}