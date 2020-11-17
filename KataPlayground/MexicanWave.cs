using System.Collections.Generic;

namespace kata_playground
{
    public partial class Kata
    {
        public List<string> wave(string str)
        {
            var result = new List<string>();
            for (var i = 0; i < str.Length; i++)
            {
                if (char.IsLetter(str[i]))
                {
                    var waveStr = str.ToCharArray();
                    waveStr[i] = char.ToUpper(str[i]);
                    result.Add(new string(waveStr));
                }
            }
            return result;
        }
    }
}