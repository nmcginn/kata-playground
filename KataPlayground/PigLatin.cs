using System.Linq;
using System.Text.RegularExpressions;

namespace kata_playground
{
    public partial class Kata
    {
        public static string PigIt(string str)
        {
            return string.Join(" ", str.Split(" ").Select(word => PigLatin(word)));
        }

        private static string PigLatin(string word)
        {
            if (word.Length <= 1)
                return word;

            var punctuationMatch = Regex.Match(word, notLetter);
            var punctuation = punctuationMatch.Length == 1 ? punctuationMatch.Value : "";
            return $"{Regex.Replace(word.Substring(1), notLetter, "")}{word[0]}ay{punctuation}";
        }

        private const string notLetter = "[^A-Za-z]";
    }
}