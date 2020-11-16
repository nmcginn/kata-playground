using System.Linq;

namespace kata_playground
{
    public partial class Kata
    {
        public static string Rot13(string message)
        {
            var messageCharacters = message.ToCharArray();
            var result = new int[messageCharacters.Length];
            for (var i = 0; i < messageCharacters.Length; i++)
            {
                if (!char.IsLetter(messageCharacters[i]))
                    result[i] = messageCharacters[i];
                else if (char.IsLower(messageCharacters[i]))
                    result[i] = messageCharacters[i] > 109 ? messageCharacters[i] - 13 : messageCharacters[i] + 13;
                else
                    result[i] = messageCharacters[i] > 77 ? messageCharacters[i] - 13 : messageCharacters[i] + 13;
            }
            return string.Join("", result.Select(c => (char)c));
        }
    }
}