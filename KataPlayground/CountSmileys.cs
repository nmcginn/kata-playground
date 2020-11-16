using System.Linq;

namespace kata_playground
{
    public partial class Kata
    {
        public static int CountSmileys(string[] smileys)
        {
            if (smileys.Length <= 0)
                return 0;
            return smileys.Where(smiley => ValidSmiley(smiley)).Count();
        }

        public static bool ValidSmiley(string smiley)
        {
            var isValid = true;
            if (smiley.First() != ';' && smiley.First() != ':')
                isValid = false;
            if (smiley.Last() != ')' && smiley.Last() != 'D')
                isValid = false;
            if (smiley.Length == 3)
            {
                var nose = smiley.Skip(1).Take(1).First();
                if (nose != '-' && nose != '~')
                    isValid = false;
            }
            return isValid;
        }
    }
}