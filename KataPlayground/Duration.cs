using System.Collections.Generic;
using System.Linq;

namespace kata_playground
{
    public partial class Kata
    {
        private static string multi(int count, string word) => count == 1 ? word : $"{word}s";

        private static string tokenize(int total, int unit, string word) => total < unit ? "" : $"{total / unit} {multi(total / unit, word)}";

        public static string formatDuration(int seconds)
        {
            if (seconds == 0)
                return "now";

            var strings = new List<string>();

            strings.Add(tokenize(seconds, 31536000, "year"));
            seconds = seconds % 31536000;

            strings.Add(tokenize(seconds, 86400, "day"));
            seconds = seconds % 86400;

            strings.Add(tokenize(seconds, 3600, "hour"));
            seconds = seconds % 3600;

            strings.Add(tokenize(seconds, 60, "minute"));
            seconds = seconds % 60;

            if (seconds != 0)
                strings.Add($"{seconds} {multi(seconds, "second")}");

            strings = strings.Where(s => !string.IsNullOrEmpty(s)).ToList();

            if (strings.Count() <= 2)
                return string.Join(" and ", strings);
            else
                return string.Join(", ", strings.Take(strings.Count() - 2)) + ", " + string.Join(" and ", strings.Skip(strings.Count() - 2).Take(2));
        }
    }
}