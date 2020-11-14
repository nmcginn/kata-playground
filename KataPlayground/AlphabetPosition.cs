using System.Text;

namespace kata_playground
{
    public partial class Kata
    {
        public static string AlphabetPosition(string text)
        {
            // return text
            //     .ToCharArray()
            //     .Where(x => char.IsLetter(x))
            //     .Select(c => c.ToString().ToLower())
            //     .Select(c => c.First().ToString())
            //     .Aggregate((current, next) => string.Format("{0} {1}", current, next));
            var result = new StringBuilder();
            foreach(var c in text.ToCharArray()) {
                if (!char.IsLetter(c))
                    continue;
                var alphabetPositionOfCharacter = (int)c - 64;
                result.AppendFormat("{0} ", alphabetPositionOfCharacter > 26 ? alphabetPositionOfCharacter - 32 : alphabetPositionOfCharacter);
            }
            return result.ToString().TrimEnd();
        }
    }
}