using System;
using System.Linq;
using System.Globalization;

namespace kata_playground
{
    public partial class Kata
    {
        public static string ToCamelCase(string str)
        {
            var words = str.Split(new char[] {'_', '-'});
            return words.First() + string.Join("", words
               .Skip(1)
               .Select(word => CultureInfo.CurrentCulture.TextInfo.ToTitleCase(word))
            );
        }
    }
}
